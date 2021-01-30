/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieChasing : MonoBehaviour
{
    public GameObject player;
    int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;

    private Transform Player;

    [SerializeField] private float m_moveSpeed = 2;
    [SerializeField] private float m_turnSpeed = 200;

    [SerializeField] private Animator m_animator = null;
    [SerializeField] private Rigidbody m_rigidBody = null;

    //[SerializeField] private ControlMode m_controlMode = ControlMode.Tank;

    private float m_currentV = 0;
    private float m_currentH = 0;

    private readonly float m_interpolation = 10;

    private Vector3 m_currentDirection = Vector3.zero;

    private void Awake()
    {
        if (!m_animator) { gameObject.GetComponent<Animator>(); }
        if (!m_rigidBody) { gameObject.GetComponent<Animator>(); }
        Player = player.transform;
    }


    void Update()
    {
        
        if (Vector3.Distance(transform.position, Player.position) >= MinDist && Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            transform.LookAt(Player);

            Transform camera = Camera.main.transform;

            m_currentV = Mathf.Lerp(m_currentV, v, Time.deltaTime * m_interpolation);
            m_currentH = Mathf.Lerp(m_currentH, h, Time.deltaTime * m_interpolation);

            Vector3 direction = camera.forward * m_currentV + camera.right * m_currentH;

            float directionLength = direction.magnitude;
            direction.y = 0;
            direction = direction.normalized * directionLength;

            if (direction != Vector3.zero)
            {
                m_currentDirection = Vector3.Slerp(m_currentDirection, direction, Time.deltaTime * m_interpolation);

                transform.rotation = Quaternion.LookRotation(m_currentDirection);
                transform.position += m_currentDirection * m_moveSpeed * Time.deltaTime;
                Debug.Log(direction.magnitude);
                m_animator.SetFloat("MoveSpeed", direction.magnitude);
            }

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
        else if(Vector3.Distance(transform.position, Player.position) < MinDist)
        {
            //attack
            m_animator.SetTrigger("Attack");

        }
    }
}*/

using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class ZombieChasing : MonoBehaviour
{

    //public Transform Player;
    int MoveSpeed = 3;
    int MaxDist = 8;
    int MinDist = 1;
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

    /*void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            //health.DecrHealth();
            /*
            red += 0.05f;
            Debug.Log(red);
            green -= 0.05f;
            Debug.Log(green);
            health.color = new Color(red, green, 0, 1);
        }

    }*/
}
