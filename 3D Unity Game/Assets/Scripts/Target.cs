using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public GameObject robot;
    bool dead = false;
    bool isHit = false;
    public float health = 40f;
    public ParticleSystem blood;

    // Follow player
    public Transform target;
    NavMeshAgent nav;

    void Start()
    {
        robot.GetComponent<Animator>().Play("Z_Idle");
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (isHit == true)
        {
            nav.SetDestination(target.position);
        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }

    public void TakeDamage(float amount) 
    {
        health -= amount;
        isHit = true;
        if (dead != true)
        {
            blood.Play();
            robot.GetComponent<Animator>().Play("Z_Run");
        }

        if (health <= 10f)
        {
            dead = true;
            isHit = false;
            robot.GetComponent<Animator>().Play("Z_FallingForward");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player" && dead != true)
        {
            nav.SetDestination(target.position);
            robot.GetComponent<Animator>().Play("Z_Attack");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player" && dead != true)
        {
            nav.SetDestination(target.position);
            robot.GetComponent<Animator>().Play("Z_Run");
        }

    }

}
