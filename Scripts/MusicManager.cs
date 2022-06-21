using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioSource[] sound = new AudioSource[6];
    PlayerMove playerMove;
    void Start()
    {
        playerMove = GameObject.FindObjectOfType<PlayerMove>();
        sound[0].Play();
    }

    public void ManStep()
    {
        if (!sound[1].isPlaying && playerMove.Moveable)
        {
            sound[1].Play();
        }  
    }
    public void MusicStop()
    {
        sound[0].Stop();
    }
    public void ManStepStop()
    {
        sound[1].Stop();
    }
    public void ManEat()
    {
        if (!sound[2].isPlaying)
        {
            sound[2].Play();
        }
           
    }
    public void ManEatStop()
    {
        sound[2].Stop();
    }
    public void ManDeath()
    {
        if (!sound[3].isPlaying )
        {
            sound[3].Play();
        }
            
    }
    public void EatBusket()
    {
        sound[4].Play();
    }
    public void EatBusketStop()
    {
        sound[4].Stop();
    }
    public void FailBusket()
    {
        sound[5].Play();
    }
    public void FailBusketStop()
    {
        sound[5].Stop();
    }
}
