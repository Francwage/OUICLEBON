using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public MovementPlane MP;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           MP.moveSpeed += 1f;
        }
    }
}
