using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickListener : MonoBehaviour
{
    private MeshRenderer _objectRenderer;
    private RaycastHit _hit;

    private void Start()
    {
        _objectRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        //If raycast through collider of Object tag => change color
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out _hit))
            {
                if(_hit.collider.CompareTag("Object"))
                {
                    //Change Color
                    ChangeObjectColor();
                    Debug.Log("Hit");
                }
            }
        }
    }

    private void ChangeObjectColor()
    {
        Color newColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        _objectRenderer.materials[0].SetColor("_Color", newColor);
    }
}
