using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject orbitalObject;
    public float speed = 30;
    public Vector3 orbit = new Vector3(0, 1, 0);

    void Update()
    {
        orbitalObject.transform.RotateAround(transform.position, orbit, speed * Time.deltaTime);
    }
}
