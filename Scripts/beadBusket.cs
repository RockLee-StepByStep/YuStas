using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beadBusket : MonoBehaviour
{
    [SerializeField] float timeDeactivateBusket;
    MusicManager Music;
    ScoreOfBusket ScoreOfBusketScoreDown;
    PlayerMove movePlayerCan;
    HealthManager healthManager;
    ActiveFX activeFX;

    void Start()
    {
        healthManager = GameObject.FindObjectOfType<HealthManager>();
        ScoreOfBusketScoreDown = GameObject.FindObjectOfType<ScoreOfBusket>();
        Music = GameObject.FindObjectOfType<MusicManager>();
        movePlayerCan = GameObject.FindObjectOfType<PlayerMove>();
        activeFX = GameObject.FindObjectOfType<ActiveFX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            movePlayerCan.Moveable = false;
            ManagerOfBuskets.isWorking = true;
            Debug.Log("Player get damage");
            StartCoroutine("timeOfDeactivate");
        }
    }

    IEnumerator timeOfDeactivate()
    {
        Music.ManEat();
        yield return new WaitForSeconds(3f);
        ManagerOfBuskets.isWorking = false;
        activeFX.ActiveEffect();
        movePlayerCan.Moveable = true;
        Music.ManEatStop();
        Music.FailBusket();
        Debug.Log("Player -----MINUS OnePoint");
        ScoreOfBusketScoreDown.ScoreDown(100);
        healthManager.GetDamage();
        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }
}
