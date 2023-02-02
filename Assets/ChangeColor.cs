using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
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
            var clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(clickRay, out hit) && hit.transform.name == transform.name)
            {
                var random = Random.ColorHSV();
                cubeRenderer.material.SetColor("_Color", random);
                ObjectToChangeRenderer.material.SetColor("_Color", random);
            }
        }
    }
}
