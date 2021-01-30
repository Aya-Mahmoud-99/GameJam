using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesAttack : MonoBehaviour
{
    [SerializeField] private Animator m_animator = null;

    // Update is called once per frame
    void Update()
    {
        m_animator.SetTrigger("Attack");
    }
}
