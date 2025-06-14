using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private float moveH;
    private float moveV;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ќтримуЇмо вх≥д з клав≥атури (в≥с≥ Horizontal ≥ Vertical)
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // –ух гравц€
        rb.velocity = new Vector2(moveH * moveSpeed, rb.velocity.y);
    }
}

