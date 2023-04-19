using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;
    [SerializeField] GameObject key;
    private bool locked;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        locked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key" && locked)
        {
            if (other.gameObject.name == key.gameObject.name)
            {
                UnlockDoor();
            }
        }
        else
        {
            Debug.Log("Error");
        }
    }

    private void UnlockDoor()
    {
        door.GetComponent<Rigidbody>().isKinematic = false;
        handle.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<BoxCollider>().isTrigger = false;
        locked = false;
        audioSource.Play();
    }
}
