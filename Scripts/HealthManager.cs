using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    DEathManager dEathManager;
    public Image[] images = new Image[3]; 
   

    public int health;
    public int numOfHerath;


    private void Start()
    {
        dEathManager = GameObject.FindObjectOfType<DEathManager>();
    }
    public void Update()
    {
        for(int i = 0; i < images.Length; i++)
        {
            if (i < numOfHerath)
            {
                images[i].enabled = true;
            } else { images[i].enabled = false; }
           
        }
        if (numOfHerath == 0)
        {
            dEathManager.DeathScene();
        }

    }

    public void GetDamage()
    {
        if (numOfHerath != 0)
        {
            numOfHerath-=1;
        }
        
    }

    
}
