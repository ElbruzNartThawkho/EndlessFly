using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int ScoreValue = -1;
    Text Score;
    void Start()
    {
        Score = GetComponent<Text>();
    }
    void Update()
    {
        Score.text = "Score : " + ScoreValue;
    }
}
