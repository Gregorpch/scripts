using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleporPoint;
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleporPoint.position;
    }
}
