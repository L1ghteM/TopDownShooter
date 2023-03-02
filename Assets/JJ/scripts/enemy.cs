using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            Vector3 diretion = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(diretion.y, diretion.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = diretion;
        }
    }

    private void FixedUpdate()
    {
        if(target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;

        }
    }
}
