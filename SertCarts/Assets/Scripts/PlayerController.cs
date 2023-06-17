using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    public float JumpAmount = 3f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveX, 0);
        movement.Normalize();

        rb.velocity = movement * moveSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up* JumpAmount, ForceMode2D.Impulse);
        }
    }
}
