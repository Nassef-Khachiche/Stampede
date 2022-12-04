using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public GameObject player;



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
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            player.GetComponent<Animator>().Play("Fire");
        }
        else 
        {
            player.GetComponent<Animator>().Play("Idle");
        }

    }
}
