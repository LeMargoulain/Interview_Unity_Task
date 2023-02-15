using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script change the color of the game object it is put on, as well as the gameobject in parameter.
public class ChangeColorOnClick : MonoBehaviour
{
    public GameObject objectToChange;
    private Renderer cubeRenderer;
    private Renderer ObjectToChangeRenderer;
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        ObjectToChangeRenderer = objectToChange.GetComponent<Renderer>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            //send a ray from the camera to the spot we clicked on
            var clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Check if the object clicked is the right one and change its color
            if (Physics.Raycast(clickRay, out hit) && hit.transform.name == transform.name)
            {
                var random = Random.ColorHSV();
                cubeRenderer.material.SetColor("_Color", random);
                ObjectToChangeRenderer.material.SetColor("_Color", random);
            }
        }
    }
}
