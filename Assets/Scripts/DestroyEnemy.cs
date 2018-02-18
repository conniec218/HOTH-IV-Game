using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision name = " + collision.gameObject.name);
        if (collision.gameObject.name == "Snowball")
            Destroy(collision.gameObject);
    }
}
