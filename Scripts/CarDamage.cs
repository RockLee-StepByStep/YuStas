using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDamage : MonoBehaviour
{

    DEathManager dEathManager;

  
    // Start is called before the first frame update
    void Start()
    {
        dEathManager = GameObject.FindObjectOfType<DEathManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is dead");
            dEathManager.DeathScene();
        }
    }
}
