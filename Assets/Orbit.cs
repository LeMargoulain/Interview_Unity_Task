using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject orbitalObject;
    public float speed = 30;
    public Vector3 orbit = new Vector3(0, 1, 0);
    private Vector3 distance = new Vector3();


    void Start()
    {
        //Save the initial distance vector between object and his orbital
        distance = orbitalObject.transform.position - transform.position;
    }
    void Update()
    {
        //Set the distance between object and his orbital
        orbitalObject.transform.position = transform.position + distance;
        //Rotate the orbital arround the object a set amount
        orbitalObject.transform.RotateAround(transform.position, orbit, speed * Time.deltaTime);
        //Recompute the distance between the object and his orbital (vector direction changed)
        distance = orbitalObject.transform.position - transform.position;
    }
}
