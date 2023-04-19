using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] GameObject chestDoor;
    [SerializeField] GameObject padlock;
    public bool locked;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        locked = true;
        chestDoor.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void UnlockChest()
    {
        chestDoor.GetComponent<Rigidbody>().isKinematic = false;
        locked = false;
        padlock.GetComponent<Rigidbody>().isKinematic = false;
        audioSource.Play();
    }
}
