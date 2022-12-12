using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject robot;
    bool dead = false;
    public float health = 40f;
    public ParticleSystem blood;
    void Start()
    {
        robot.GetComponent<Animator>().Play("Z_Idle");
    }

    public void TakeDamage(float amount) 
    {
        health -= amount;
        if (dead != true)
        {
            blood.Play();
            robot.GetComponent<Animator>().Play("Z_Run");
        }

        if (health <= 0f)
        {
            dead = true;
            robot.GetComponent<Animator>().Play("Z_FallingForward");
        }
    }
}
