using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject bullet;
    public float fireRate;
    public float nextFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        gameObject.transform.position = new Vector2(transform.position.x + (h * moveSpeed),
   transform.position.y + (v * moveSpeed));
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
