using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Vector3 center; // save the sphere center here
    void Start()
    { // Find sphere only once:
        center = GameObject.Find("Sphere").transform.position;
    }
    void Update()
    {
        float rotAngle = Input.GetAxis("Vertical")  * 1.3f;
        // rotate around sphere about world Y
        this.transform.RotateAround(center, Vector3.right, rotAngle);
    }
}
