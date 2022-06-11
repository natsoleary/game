using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public int ScoreToPass = 30; 
    
    // Start is called before the first frame update

    public static void EarnScore()
    {
        CurrentScore += 5;
        GameObject ui_handler = GameObject.Find("UIHandler");
        ExecuteEvents.Execute<IPizzaTowerUIMessageTarget>(ui_handler, null, (x, y) => x.IncrementScore(5));
    }
    void Start()
    {
        GameObject ui_handler = GameObject.Find("UIHandler");
        ExecuteEvents.Execute<IPizzaTowerUIMessageTarget>(ui_handler, null, (x, y) => x.SetScoreRequired(30));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}