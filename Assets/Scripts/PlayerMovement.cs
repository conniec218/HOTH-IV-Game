using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    const float xMin = -9;
    const float xMax = 0;
    const float yMin = -3;
    const float yMax = 2;

    Vector3 pos;
    Transform tr;

    void Start()
    {
        pos = transform.position;
        tr = transform;
    }

    void Update() {
        movePlayer();
}

void movePlayer()
{
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && tr.position == pos)
        {
            if (pos.x + 3 < xMax)
                pos.x += 3;
        }
        else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && tr.position == pos)
        {
            if (pos.x - 3 > xMin)
                pos.x -= 3;
        }
        else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && tr.position == pos)
        {
            if (pos.x + .5 < xMax && pos.y + 2 < yMax)
            {
                pos.y += 2;
                pos.x += (float)0.5;
            }
        }
        else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && tr.position == pos)
        {
            if (pos.x - .5 > xMin && pos.y - 2 > yMin)
            {
                pos.y -= 2;
                pos.x -= (float)0.5;
            }
        }
        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ESnowball(Clone)")
        {
            PHealth.health -= 1;
            Destroy(collision.gameObject);
        }

    }
}