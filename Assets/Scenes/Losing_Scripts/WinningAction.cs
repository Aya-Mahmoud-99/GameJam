using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningAction : MonoBehaviour
{
    [SerializeField] private Animator m_animator = null;
    // Start is called before the first frame update
    void Start()
    {
        m_animator.SetTrigger("Dead");
    }

}
