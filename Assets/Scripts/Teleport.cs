using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject point;

    private void OnCollisionEnter(Collision other)
    {
        other.transform.position = point.transform.position;
    }
}
