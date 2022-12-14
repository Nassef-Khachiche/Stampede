using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public GameObject player;
    public GameObject hostage;


    void Start()
    {

    }

    void Update()
    {
        PlayAnimation();
    }

    public void PlayAnimation() 
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            player.GetComponent<Animator>().Play("Run");
            hostage.GetComponent<Animator>().Play("Z_Walk1");

        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            player.GetComponent<Animator>().Play("Fire");
            hostage.GetComponent<Animator>().Play("Z_Walk1");
        }
        else 
        {
            player.GetComponent<Animator>().Play("Idle");
            hostage.GetComponent<Animator>().Play("Z_Walk1");
        }

    }
}
