using UnityEngine;
using System.Collections;

public class Orbit1 : MonoBehaviour
{

    public GameObject Satellite1; // the cube game obj that will orbit around
    public float speed; // speed of the orbiting red cube 
                        // use this for initialization

    void Start(){
        
    }

    //update is called once per frame
    void Update(){
        OrbitAround(); // This function or method will make the red cube orbit around the other
    }

    void OrbitAround(){
        transform.RotateAround(Satellite1.transform.position, Vector3.up, speed * Time.deltaTime); // make red cube orbit around the white cube
    }





}