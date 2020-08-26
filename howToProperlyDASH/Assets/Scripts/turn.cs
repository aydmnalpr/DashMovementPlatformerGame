using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        gameObject.transform.localScale = new Vector2 (player.transform.localScale.x , gameObject.transform.localScale.y);
    }
}
