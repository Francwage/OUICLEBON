using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileUp : MonoBehaviour
{
   public GameObject Avion;

   private PlayerShooter PS;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           if(PS._timer <= 0.25f)
           {
               PS._timer= 0.25f;
           }
           else
           {
               PS._timer = PS._timer / 2;
           }
        }
    }

    void Start()
    {
           Avion.GetComponent("PlayerShooter");
    }
}
