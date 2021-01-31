using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public Text StartText;
    bool shrink;
    int size;
    int t;

    void Start()
    {
        shrink = false;
        size = 40;
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Scene2");
        }

        if (size>50 || size < 30)
        {
            shrink = !shrink;
            if (shrink)
            {
                size--;
            }
            else
            {
                size++;
            }
        }
        
        t++;
        if (t >= 20)
        {
            StartText.fontSize = shrink ? size-- : size++;
            t = 0;
        }

        
        
        
    }
    
}

