using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    private int currentHealth;
    public HealthBar healthBar;
    //public int noOfBrains;
    public BrainCollision b;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        healthBar.SetMaxHealth(health);
    }

    public void DecrHealth()
    {
        if (health > 0)
        {
            health -= 5;
            healthBar.SetHealth(health);
        }
        else
        {
            Death();
            //SceneManager.LoadScene("Menu");
        }

    }

    public void Death()
    {
        int noOfBrains = b.getScore();
        if (noOfBrains == 7)
        {
            //Win
            SceneManager.LoadScene("Won");
        }
        else
        {
            //lose
            SceneManager.LoadScene("Lost");
        }
    }
    
}
