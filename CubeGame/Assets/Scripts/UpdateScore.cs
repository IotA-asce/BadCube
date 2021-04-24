using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public Text pointsText;
    public Text timeText;

    public void UpdateData(int score, float time)
    {
        pointsText.text = "SCORE : " + score.ToString();
        timeText.text = "Time : " + time.ToString();
    }
}
