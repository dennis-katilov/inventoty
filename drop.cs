using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDropedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + 2, player.position.Y -1)
    }

}
