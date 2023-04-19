using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place2Trigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Doll")
        {
            GameEvents.current.SetPlace2Active();
            Debug.Log("place 2 active");
        }
        else
        {
            Debug.Log("Error");
        }
    }
}