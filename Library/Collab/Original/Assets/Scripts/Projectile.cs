using UnityEngine;
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
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Enemy")
        {
            Debug.Log("Collision");
            Destroy(coll.gameObject);
        }
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SnowBall : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;
    public Animator impact;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        impact = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            Vector2 v = new Vector2(1, 0).normalized * speed;
            rb.velocity = v;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            impact.SetTrigger("impact");
            speed = 0;
            Destroy(col.gameObject, 1);
        }
    }
}*/


