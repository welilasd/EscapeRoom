using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Padlock : MonoBehaviour
{
    [SerializeField] GameObject[] pins;
    [SerializeField] int rotAmount = -36;

    [Range(0, 9)]
    [SerializeField] int[] unlockCombination;

    [SerializeField] int[] currentCombination;

    [SerializeField] GameObject chestDoor;

    private void Start()
    {
        currentCombination = new int[] { 1, 1, 1, 1 };
    }
    public void RotateLock(int currentPin)
    {
        Quaternion newRot = pins[currentPin].transform.rotation * Quaternion.Euler(rotAmount, 0, 0);
        pins[currentPin].transform.rotation = newRot;

        if(currentCombination[currentPin] < 9)
        {
            currentCombination[currentPin] += 1;
        }
        else
        {
            currentCombination[currentPin] = 0;
        }

        if (ArrayUtility.ArrayEquals(unlockCombination, currentCombination))
        {
            chestDoor.GetComponent<Chest>().UnlockChest();
        }
        else
        {
            Debug.Log("Error");
        }

    }
}
