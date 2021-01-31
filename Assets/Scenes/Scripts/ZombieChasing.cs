using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZombieChasing : MonoBehaviour
{

    //public Transform Player;
    int MoveSpeed = 3;
    int MaxDist = 8;
    float MinDist = 0.5f;
    public GameObject player;
    private Transform Player;
    //public Image health;
    public PlayerHealth health;
    private float t=0 ;

    [SerializeField] private Animator m_animator = null;


    void Start()
    {
        Player = player.transform;
    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {


            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                //Here Call any function U want Like Shoot at here or something
            }

        }
        else if (Vector3.Distance(transform.position, Player.position) < MinDist)
        {
            if (t == 0)
            {
                t += Time.deltaTime;
                m_animator.SetTrigger("Attack");
                health.DecrHealth();
            }
            else
            {
                t += Time.deltaTime;
                float seconds = Mathf.FloorToInt(t % 60);
                if (seconds >= 2)
                {
                    t = 0;
                }
            }

        }
    }

}
