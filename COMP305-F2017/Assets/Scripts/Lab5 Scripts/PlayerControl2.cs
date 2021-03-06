﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rbody;
    private float moveHorizontal;
    private float moveVertical;
    private Vector2 movement;

    public GameObject gm;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = Input.GetAxis("Vertical");

            movement = new Vector2(0, moveVertical);

            // Limits max speed
            if (rbody.velocity.magnitude < speed)
            {
                rbody.AddForce(movement * speed);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVertical = Input.GetAxis("Vertical");

            movement = new Vector2(0, moveVertical);

            // Limits max speed
            if (rbody.velocity.magnitude < speed)
            {
                rbody.AddForce(movement * speed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = Input.GetAxis("Horizontal");

            movement = new Vector2(moveHorizontal, 0);

            // Limits max speed
            if (rbody.velocity.magnitude < speed)
            {
                rbody.AddForce(movement * speed);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = Input.GetAxis("Horizontal");

            movement = new Vector2(moveHorizontal, 0);

            // Limits max speed
            if (rbody.velocity.magnitude < speed)
            {
                rbody.AddForce(movement * speed);
            }
        }

        // This slows down the speed of the player gradually
        if (rbody.velocity.magnitude > 0)
        {
            movement = rbody.velocity - (rbody.velocity / 10);
            rbody.velocity = movement;
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Bolt(Clone)")
        {
            gm.SendMessage("Collected", "bolt");
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "Nut(Clone)")
        {
            gm.SendMessage("Collected", "nut");
            Destroy(col.gameObject);
        }
        else if (col.gameObject.name == "Screw(Clone)")
        {
            gm.SendMessage("Collected", "screw");
            Destroy(col.gameObject);
        }
    }

}