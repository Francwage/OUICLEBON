using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldup : MonoBehaviour
{
    public MovementPlane MP;

    void Start()
    {
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           MP.secondLife = true;
        }
    }
}
