using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrainCollision : MonoBehaviour
{
    public Text text;
    private int score = 0;

    public int getScore()
    {
        return score;
    }
    

    void Start()
    {
        text.text = score.ToString() + " / 7";
        

    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Brain")
        {
            Destroy(col.gameObject);
            score++;
            text.text = score.ToString()+" / 7";
            if (score == 7)
            {
                SceneManager.LoadScene("Won");
            }
        }

    }

}
