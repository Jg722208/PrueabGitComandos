using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    private const int ANIMATION_QUIETO = 0;
    private const int ANIMATION_CAMINAR = 1;


    private Rigidbody2D rb; //Pisicion
    private Animator animator; //Movimiento
    private SpriteRenderer sr;
    void Start()
    {
        //Aumentar disminuir la velocidad del objeto
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        animator.SetInteger("Estado", ANIMATION_QUIETO); //Siempre vuelve a este valor
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
            animator.SetInteger("Estado", ANIMATION_CAMINAR); //Seteo un valor para la animación
           sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-10, rb.velocity.y);
            animator.SetInteger("Estado", ANIMATION_CAMINAR); //Seteo un valor para la animación
            sr.flipX = true;

        }
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.velocity = new Vector2(0, 5);
        //}

        //Para Saltar
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 30), ForceMode2D.Impulse);
        }
    }
}
