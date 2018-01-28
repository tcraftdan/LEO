using UnityEngine;
using System.Collections;

public class Orbit2 : MonoBehaviour
{

    public GameObject Satellite2; // the cube game obj that will orbit around
    public float speed; // speed of the orbiting red cube 
                        // use this for initialization

    void Start()
    {

    }

    //update is called once per frame
    void Update()
    {
        OrbitAround(); // This function or method will make the red cube orbit around the other
    }

    void OrbitAround()
    {
        transform.eulerAngles = new Vector3(45, speed, 0);
        transform.RotateAround(Satellite2.transform.position, transform.eulerAngles, speed * Time.deltaTime); // make red cube orbit around the white cube
    }





}