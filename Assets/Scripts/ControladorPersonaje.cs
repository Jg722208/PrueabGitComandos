using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection.Emit;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);

        if (Input.GetKey(KeyCode.RightArrow))
        {

            rb.velocity = new Vector2(10, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.velocity = new Vector2(-10, rb.velocity.y);
            }
         }
    }