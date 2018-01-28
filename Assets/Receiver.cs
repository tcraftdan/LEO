using UnityEngine;
using System.Collections;
using System;

public class Receiver : MonoBehaviour
{


    // positionOnSphere is the X,Y,Z point on the surface of the sphere (in world space).
    void PositionObjectOnSphere(Transform ourSphere, Transform ourObject, Vector3 positionOnSphere)
    {

        // Get our X,Y,Z on the sphere as if the sphere were at the origin;
        Vector3 originPositionOnSphere = ourObject.position - ourSphere.position;

        // Theta = our rotaation about the y-Axis. it can be from 0->360
        // Think of it as an angle going around the Equator
        float theta = 0f;
        // Phi = our rotation about the z-Axis. It can be from 0 to 180.
        //Think of it as an angle going from the north pole to the south pole
        float phi = 0f;

        // these 2 angle (plus a radius) uniquely define a point on the sphere.
        // So we will take our X,Y,Z point and convert it to these co-ordinates
        // this will get the proper rotation for our object to sit on the sphere correctly.
        GetSphericalCoordinates(originPositionOnSphere, ref theta, ref phi);


        Vector3 rotateAngles = new Vector3(0f, theta, phi);
        // If our object is NOT a child of the sphere and the sphere might be rotated
        // you need to add in the sphere's rotation, since those x,y,z might not be
        // in the same spot on a rotated sphere.
        rotateAngles += ourSphere.transform.eulerAngles; // only if your not the child
        ourObject.Rotate(rotateAngles);

        ourObject.transform.position = positionOnSphere;
    }

    void GetSphericalCoordinates(Vector3 originPositionOnSphere, ref float theta, ref float phi)
    {

        // all the following formulas are basic Math Spherical Coordinate formulas
        float x = originPositionOnSphere.x;
        float y = originPositionOnSphere.y;
        float z = originPositionOnSphere.z;
        float radius = Mathf.Sqrt(x * x + y * y + z * z);
        if (radius < 0)
            throw new ArgumentException("Radius Less than 0 in GetSphericalCoordinate");

        // ACos will always be between 0 and 180 so we are good
        // we need to clamp these just in case rounding errors
        // make them 1.00001  or -1.0005
        float phiValue = y / radius;
        phiValue = Mathf.Clamp(phiValue, -1f, 1f);
        phi = Mathf.Acos(phiValue);

        float thetaValue = z / (radius * Mathf.Sin(phi));
        thetaValue = Mathf.Clamp(thetaValue, -1f, 1f);
        theta = Mathf.Asin(thetaValue);



        // Both these angle are in radians
        // Lets make them degrees
        phi = phi * 180f / Mathf.PI;
        theta = theta * 180f / Mathf.PI;

        // Asin returns a number between -90 and 90
        // Since this can be form 0->360 we need have two options each for positive and negative angles
        if (theta < 0)
        {
            // Quadrant III
            if (x < 0)
            {
                theta = 180f - theta;
            }
            //Quadrant IV
            else
            {
                theta = 360 + theta;
            }
        }
        else
        {
            // Quadrant II
            if (x < 0)
            {
                theta += 90;
            }
            // Quadrant I we do nothing
        }

        // Now theta is 0->360 *CounterClockwise* from the *X-Axis* (Normal Math)
        // we need it *ClockWise* from the *Z-Axis* (Unity)
        theta -= 90;
        theta = 360 - theta;
        if (theta >= 360)
            theta -= 360;
    }
}