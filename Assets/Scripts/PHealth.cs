using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHealth : MonoBehaviour
{

    public static int health;
    public GameObject PLife1, PLife2, PLife3, PLife4, PLife5, gameOver; //ELife1, ELife2, ELife3, ELife4, ELife5, gameOver; 
    // Use this for initialization
    void Start()
    {
        health = 5;
        PLife1.gameObject.SetActive(true);
        PLife2.gameObject.SetActive(true);
        PLife3.gameObject.SetActive(true);
        PLife4.gameObject.SetActive(true);
        PLife5.gameObject.SetActive(true);
        /*ELife1.gameObject.SetActive(true);
        ELife2.gameObject.SetActive(true);
        ELife3.gameObject.SetActive(true);
        ELife4.gameObject.SetActive(true);
        ELife5.gameObject.SetActive(true);*/
        gameOver.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (health > 5)
            health = 5;

        switch (health)
        {
            case 5:
                PLife1.gameObject.SetActive(true);
                PLife2.gameObject.SetActive(true);
                PLife3.gameObject.SetActive(true);
                PLife4.gameObject.SetActive(true);
                PLife5.gameObject.SetActive(true);
                break;
            case 4:
                PLife1.gameObject.SetActive(true);
                PLife2.gameObject.SetActive(true);
                PLife3.gameObject.SetActive(true);
                PLife4.gameObject.SetActive(true);
                PLife5.gameObject.SetActive(false);
                /*ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(true);
                ELife5.gameObject.SetActive(true);*/
                break;
            case 3:
                PLife1.gameObject.SetActive(true);
                PLife2.gameObject.SetActive(true);
                PLife3.gameObject.SetActive(true);
                PLife4.gameObject.SetActive(false);
                PLife5.gameObject.SetActive(false);
                /*ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(true);
                ELife5.gameObject.SetActive(true);*/
                break;
            case 2:
                PLife1.gameObject.SetActive(true);
                PLife2.gameObject.SetActive(true);
                PLife3.gameObject.SetActive(false);
                PLife4.gameObject.SetActive(false);
                PLife5.gameObject.SetActive(false);
                /*ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(true);
                ELife5.gameObject.SetActive(true);*/
                break;
            case 1:
                PLife1.gameObject.SetActive(true);
                PLife2.gameObject.SetActive(false);
                PLife3.gameObject.SetActive(false);
                PLife4.gameObject.SetActive(false);
                PLife5.gameObject.SetActive(false);
                /*ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(true);
                ELife5.gameObject.SetActive(true);*/
                break;
            case 0:
                PLife1.gameObject.SetActive(false);
                PLife2.gameObject.SetActive(false);
                PLife3.gameObject.SetActive(false);
                PLife4.gameObject.SetActive(false);
                PLife5.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                /*ELife1.gameObject.SetActive(true);
                ELife2.gameObject.SetActive(true);
                ELife3.gameObject.SetActive(true);
                ELife4.gameObject.SetActive(true);
                ELife5.gameObject.SetActive(true);*/
                break;
        }
    }
}
