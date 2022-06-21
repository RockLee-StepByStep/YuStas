using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busketDeactivate : MonoBehaviour
{
    [SerializeField] float timeDeactivateBusket;
    ScoreOfBusket scoreBuscetScore;
    MusicManager Music;
    PlayerMove movePlayerCan;
    ActiveFX activeFX;

    private void Start()
    {
        Music= GameObject.FindObjectOfType<MusicManager>();
        scoreBuscetScore = GameObject.FindObjectOfType<ScoreOfBusket>();
        movePlayerCan = GameObject.FindObjectOfType<PlayerMove>();
        activeFX = GameObject.FindObjectOfType<ActiveFX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ManagerOfBuskets.isWorking = true;
            Debug.Log("bool is  " + ManagerOfBuskets.isWorking);
            StartCoroutine("timeOfDeactivate");
            movePlayerCan.Moveable = false;
        }
    }

    IEnumerator timeOfDeactivate()
    {
        Music.ManEat();
        yield return new WaitForSeconds(3f);
        ManagerOfBuskets.isWorking = false;
        Music.ManEatStop();
        Music.EatBusket();
        activeFX.ActiveEffect();
        movePlayerCan.Moveable = true;
        Debug.Log("PLUS ONE POINT" );
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        scoreBuscetScore.ScoreUp(100);
    }
}
