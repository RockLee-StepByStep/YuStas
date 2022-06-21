using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryLevel : MonoBehaviour
{
    public void LoadLvl()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
