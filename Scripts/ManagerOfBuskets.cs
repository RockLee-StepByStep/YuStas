using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerOfBuskets : MonoBehaviour
{
    [SerializeField] GameObject[] pointOfBusket = new GameObject[8];


    
    [SerializeField] List<GameObject> busketScore;
    [SerializeField] GameObject poison;
    [SerializeField] GameObject busket;
    [SerializeField] public static bool isWorking;

    private int randomnumber;

    void Start()
    {
        StartCoroutine("SpawnBusket");
        busketScore.AddRange(pointOfBusket);
    }

  IEnumerator SpawnBusket()
    {
        for (int i = 0; i < pointOfBusket.Length; i++)
        {
            SpawnBuskets();
            yield return new WaitForSeconds(2);


           
        }
        //yield return new WaitForSeconds(1);
    }
         void SpawnBuskets()
        {
          randomnumber = UnityEngine.Random.Range(0, busketScore.Count);

         
          int spawn = randomnumber;
          int RandomNumber =  UnityEngine.Random.Range(0,2);

          
           GameObject ObjectForSpawn;

        if (RandomNumber % 2 == 0)
        {
            ObjectForSpawn = poison;
        }
        else { ObjectForSpawn = busket; }

            Instantiate(ObjectForSpawn, pointOfBusket[spawn].transform.position, Quaternion.Euler(281.687866f, 55.0286522f, 34.4095802f));
        }

    

    //[SerializeField] private int range = 20;  // Hom many items you want, will show in Inspector
    //List<int> list = new List<int>();
    //void Start()
    //{
    //    FillList();
    //}

    //void FillList()
    //{
    //    for (int i = 0; i < range; i++)
    //    {
    //        list.Add(i);
    //    }
    //}

    //int GetNonRepeatRandom()
    //{
    //    if (list.Count == 0)
    //    {
    //        return -1; // Maybe you want to refill
    //    }
    //    int rand = Random.Range(0, list.Count);
    //    int value = list[rand];
    //    list.RemoveAt(rand);
    //    return value;
    //}

}
