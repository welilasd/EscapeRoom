using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place4Trigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gargoyle")
        {
            GameEvents.current.SetPlace4Active();
            Debug.Log("place 4 active");
        }
        else
        {
            Debug.Log("Error");
        }
    }
}
