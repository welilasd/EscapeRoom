using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action eventPlaceActive;
    public event Action eventPlace2Active;
    public event Action eventPlace4Active;

    public void SetPlaceActive()
    {
        Debug.Log("Event function called");
        if(eventPlaceActive != null)
        {
            eventPlaceActive();
        }
        else
        {
            Debug.Log("Error");
        }
    }
    public void SetPlace2Active()
    {
        Debug.Log("Event 2 function called");
        if (eventPlace2Active != null)
        {
            eventPlace2Active();
        }
        else
        {
            Debug.Log("Error");
        }
    }

    public void SetPlace4Active()
    {
        Debug.Log("Event 4 function called");
        if (eventPlace4Active != null)
        {
            eventPlace4Active();
        }
        else
        {
            Debug.Log("Error");
        }
    }
}
