using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Animator animator;
    public float enemyspeed = 10f;
    private Vector3 move;
    

    // Start is called before the first frame update
    void Start()
    {
        move = transform.right * enemyspeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move);
        animator.SetFloat("speed", enemyspeed);
        // And then smoothing it out and applying it to the character

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("door1"))
        {
            move = move * -1;
            Debug.Log("Slide to the other side!");

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;

        }
    }
}
