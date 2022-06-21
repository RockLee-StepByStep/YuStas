using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreOfBusket : MonoBehaviour
{
    TMP_Text TextMeshProText;
    //[SerializeField] public int score;
    int NumberOfScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProText = GetComponent<TMP_Text>();
        TextMeshProText.text = "Your schore : 0";
        NumberOfScore = 0;
    }

    void Update()
    {
        
        TextMeshProText.text = "Your schore :  " + NumberOfScore;
    }

    public void ScoreUp(int amountScore)
    {
        NumberOfScore += amountScore;
    }

    public void ScoreDown(int amountScore)
    {
        NumberOfScore -= amountScore;
        if (NumberOfScore < 0) 
        { NumberOfScore = 0; }
    }
}
