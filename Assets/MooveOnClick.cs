using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script allow a game object to moove to the clicked point
public class MooveOnClick : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            // Set the destination of the object to the clicked location
            Ray clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(clickRay, out hit))
                agent.SetDestination(hit.point);

        }
    }
}
