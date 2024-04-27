using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Invenyory invenyory;
    public int i;

    private void Start()
    {
        //find a player by tag "Player"
        invenyory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

   private void Update() 
   {
        if (transform.childCount <= 0)
        {
            invenyory.isFull[i] = false;
        }
   }

}