﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    private Rigidbody2D rb2d;
    private Vector2 vel;
    public float speed = 50;
    void GoBall()
    {
        float rand = Random.Range(0, 2); //makes the ball shoot randomly from starting position
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(10, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-10, -15));
        }
    }

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>(); //adding speed to ball
        Invoke("GoBall", 2);
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void ResetBall() //resetting ball everytime a player scores.
    {
        vel = Vector2.zero;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = vel;
        transform.position = Vector2.zero;
    }

    void RestartGame() //resetting ball everytime a player scores.
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player")) //when colliding with tagged "Player" divide velocity
        {
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
