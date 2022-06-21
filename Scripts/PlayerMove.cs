using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    public MusicManager Music;
    public NavMeshAgent agentPlayer;
    public Animator animForPlayer;
    public Camera MeinCamera;
    //[SerializeField] AudioSource ManWalkSound;
    private bool _isRunning;


    public bool Moveable = true;

    private void Start()
    {
        Music = GameObject.FindObjectOfType<MusicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        MakeWork();
        MovePlayer();
        MakeSoundOfWalk();
    }

    private void MakeWork()
    {
        if (ManagerOfBuskets.isWorking)
        {
            animForPlayer.SetBool("IsWorking", true);
        }
        else
        {
            animForPlayer.SetBool("IsWorking", false);
        }
    }

    void MovePlayer()
    {
        if (Moveable)
        {
            if (Input.GetMouseButton(0))
            {
                Ray myRay = MeinCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(myRay, out hit))
                {
                    agentPlayer.SetDestination(hit.point);
                }
            }

            if (agentPlayer.remainingDistance <= agentPlayer.stoppingDistance)
            {

                _isRunning = false;
            }
            else
            {

                _isRunning = true;
            }
            animForPlayer.SetBool("IsRunning", _isRunning);
        }
        
    }

    void MakeSoundOfWalk()
    {
        if (_isRunning)
        {
         
           
                Music.ManStep();
            
           
        }
        else { Music.ManStepStop();}
    }


   
}
