using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Invenyory invenyory;
    //item in slot
    public GameObject slotButton;

    private void Start()
    {
        //find a player by tag "Player"
        invenyory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    //function for player interaction with an item
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //if the item touched the Player tag
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < invenyory.slot.length; i++)
            {
                //fill the slots
                if (invenyory.isFull[i] == false)
                {
                    invenyory.isFull[i] = true;
                    Instantiate(slotButton, invenyory.slots[i].transform);
                    Destroy(GameObject);
                    break;
                }
            }
        }
    }
}
