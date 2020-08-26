using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkIfGrounded : MonoBehaviour
{
    public playerWalking playerScript;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            playerScript.grounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            playerScript.grounded = false;
        }
    }
}