using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyStorage : MonoBehaviour
{
    [SerializeField] GameObject Key;
    public bool activePlace = false;
    public bool activePlace2 = false;
    public bool activePlace4 = false;

    // Start is called before the first frame update
    void Start()
    {
        Key.SetActive(false);
        GameEvents.current.eventPlaceActive += Active;
        GameEvents.current.eventPlace2Active += Active2;
        GameEvents.current.eventPlace4Active += Active4;
    }

    public void Active()
    {
        activePlace = true;
        Debug.Log("key place active");

        if ((activePlace == true) && (activePlace2 == true) && (activePlace4 == true))
        {
            ShowKey();
        }

        else
        {
            Debug.Log("Error");
        }
    }

    public void Active2()
    {
        activePlace2 = true;
        Debug.Log("key place 2 active");

        if ((activePlace == true) && (activePlace2 == true) && (activePlace4 == true))
        {
            ShowKey();
        }

        else
        {
            Debug.Log("Error");
        }
    }

    public void Active4()
    {
        activePlace4 = true;
        Debug.Log("key place 4 active");

        if ((activePlace == true) && (activePlace2 == true) && (activePlace4 == true))
        {
            ShowKey();
        }

        else
        {
            Debug.Log("Error");
        }
    }
    private void ShowKey()
    {
        Key.SetActive(true);
    }
}
