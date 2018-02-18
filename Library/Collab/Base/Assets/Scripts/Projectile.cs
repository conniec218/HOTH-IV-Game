﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    int controller;
    public Rigidbody2D projectile;
    public Transform Spawnpoint;

    // Use this for initialization
    void Start()
    {
        controller = 60;
    }

    // Update is called once per frame
    void Update()
    {
        controller++;
        if (Input.GetKeyDown(KeyCode.Space) && controller >= 60)
        {
            Rigidbody2D clone;
            clone = (Rigidbody2D)Instantiate(projectile, Spawnpoint.position, Quaternion.identity);

            clone.velocity = Spawnpoint.TransformDirection(Vector3.right * 5);
            controller = 0;
        }
    }
}