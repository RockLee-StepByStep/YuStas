using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNotrepeat : MonoBehaviour
{
    public GameObject[] G_Oject;
    int randomNUmbr;
    public List<int> TakeList = new List<int>();
    [SerializeField] GameObject poison;
    [SerializeField] GameObject busket;



    private void Start()
    {
        TakeList = new List<int>(new int[G_Oject.Length]);  
        StartCoroutine("MakeSpawn");
    }


    IEnumerator MakeSpawn()
    {
        for (int i = 0; i < G_Oject.Length; i++)
        {
            randomNUmbr = UnityEngine.Random.Range(1, (G_Oject.Length) + 1);
            while (TakeList.Contains(randomNUmbr))
            {
                randomNUmbr = UnityEngine.Random.Range(1, (G_Oject.Length) + 1);
            }
            TakeList[i] = randomNUmbr;
            yield return new WaitForSeconds(2);
            Debug.Log(randomNUmbr);

            int RandomNumbr = UnityEngine.Random.Range(0, 2);

            GameObject GameObjectForSpawn;
            if (RandomNumbr % 2 == 0)
            {
                GameObjectForSpawn = poison;
            }
            else { GameObjectForSpawn = busket; }

            Instantiate(GameObjectForSpawn, G_Oject[randomNUmbr - 1].transform.position, Quaternion.Euler(281.687866f, 55.0286522f, 34.4095802f));
        }
        
    }

   

}
