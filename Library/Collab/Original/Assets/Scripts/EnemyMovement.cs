using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    int counter;

    const float xMin = 0;
    const float xMax = 9;
    const float yMin = -3;
    const float yMax = 2;

    Vector3 pos;
    // Transform tr;

    void Start()
    {
        pos = transform.position;
        // tr = transform;
        counter = 0;
    }

    void Update()
    { 
        if (counter == 30)
        {
            moveEnemy();
            counter = 0;
        }
        counter++;
    }

    void moveEnemy()
    {
        int random = Random.Range(0, 4);
        if (random == 0)
        {
            if (pos.x + 3 < xMax)
                pos.x += 3;
        }
        else if (random == 1)
        {
            if (pos.x - 3 > xMin)
                pos.x -= 3;
        }
        else if (random == 2)
        {
            if (pos.x + .5 < xMax && pos.y + 2 < yMax)
            {
                pos.y += 2;
                pos.x += (float)0.5;
            }
        }
        else if (random == 3)
        {
            if (pos.x - .5 > xMin && pos.y - 2 > yMin)
            {
                pos.y -= 2;
                pos.x -= (float)0.5;
            }
        }
        transform.position = pos;
    }

}

