using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0),Space.World);
    }
}
