using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahogarse : MonoBehaviour
{
    public GameObject player;
    private Animator m_Animator;
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        m_Animator.SetTrigger("Golpe Mortal");
        manager.GameOver();
    }
}
