using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ehealth : MonoBehaviour
{

    public static int health;
    public GameObject ELife1, ELife2, ELife3, ELife4, ELife5, gameOver; 
    // Use this for initialization
    void Start()
    {
        health = 5;
        ELife1.gameObject.SetActive(true);
        ELife2.gameObject.SetActive(true);
        ELife3.gameObject.SetActive(true);
        ELife4.gameObject.SetActive(true);
        ELife5.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (health > 5)
            health = 5;

        switch (health)
        {
            case 4:
                ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(true);
                ELife5.gameObject.SetActive(false);
                break;
            case 3:
                ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(false);
                ELife5.gameObject.SetActive(false);
                break;
            case 2:
                ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(false);
                ELife4.gameObject.SetActive(false);
                ELife5.gameObject.SetActive(false);
                break;
            case 1:
                ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(false);
                ELife3.gameObject.SetActive(false);
                ELife4.gameObject.SetActive(false);
                ELife5.gameObject.SetActive(false);
                break;
            case 5:
                ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(true);
                ELife5.gameObject.SetActive(true);
                break;
            case 0:
                Time.timeScale = 0;
                ELife1.gameObject.SetActive(false);
                ELife2.gameObject.SetActive(false);
                ELife3.gameObject.SetActive(false);
                ELife4.gameObject.SetActive(false);
                ELife5.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                break;
        }
    }
}
