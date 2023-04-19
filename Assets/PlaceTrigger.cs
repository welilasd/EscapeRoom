using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Clown")
        {
            GameEvents.current.SetPlaceActive();
            Debug.Log("place active");
        }
        else
        {
            Debug.Log("Error");
        }
    }
}
