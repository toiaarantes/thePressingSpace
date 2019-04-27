using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector2 force = transform.up * speed;
            rb.AddForce(force, ForceMode2D.Force);
        }
    }
}
