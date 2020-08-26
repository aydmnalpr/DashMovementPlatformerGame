using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHit : MonoBehaviour
{
    private Animator animator;
    public GameObject punchParticle;
    public Animator camAnim;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "hitbox")
        {
            animator.SetTrigger("attacked");
            camAnim.SetTrigger("shake");
            Instantiate(punchParticle,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Quaternion.identity);
        }
    }
}
