using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPanelActive : MonoBehaviour
{
    DEathManager dEathManager;
    Animator animatorDEATH;
    void Start()
    {
        animatorDEATH = GetComponent<Animator>();
        dEathManager = GameObject.FindObjectOfType<DEathManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dEathManager.PlayerDied)
        {
            animatorDEATH.SetBool("DeathAble", true);
        }
    }
}
