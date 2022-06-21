using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEathManager : MonoBehaviour
{

    MusicManager musicManager;
    PlayerMove playerMove;
    public bool PlayerDied = false;

    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        playerMove = GameObject.FindObjectOfType<PlayerMove>();
    }

    public void DeathScene()
    {

        Time.timeScale = 1;
        PlayerDied = true;
        playerMove.Moveable = false;
        musicManager.MusicStop();
        musicManager.ManStepStop();
        musicManager.FailBusketStop();
        musicManager.ManDeath();
    }
}
