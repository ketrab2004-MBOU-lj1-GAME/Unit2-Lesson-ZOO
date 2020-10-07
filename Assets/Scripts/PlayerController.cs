﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float sideRange = 20f;
    public GameObject projectilePrefab;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // keep player in bounds
        if (transform.position.x < -sideRange)
        {
            transform.position = new Vector3(-sideRange, transform.position.y, transform.position.z);
        }else if (transform.position.x > sideRange)
        {
            transform.position = new Vector3(sideRange, transform.position.y, transform.position.z);
        }
        
        //projectile
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
