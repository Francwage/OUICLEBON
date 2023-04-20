using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileUp : MonoBehaviour
{
   public PlayerShooter PS;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           if(PS._timer<=0.25)
           {
                PS._timer= 0.25;
           }
           else
           {
                PS.timer = PS._timer / 2;
           }
        }
    }
}
