using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour {

    public int minute;
    public int second;
    private float timeLeft;
    public TextMeshProUGUI timerText;

    void Start ()
    {
        timeLeft = minute * 60 + second;
	}
	
    public void AddTime(int secondsToAdd)
    {
        timeLeft += secondsToAdd;
    }

    private void UpdateTimeText()
    {
        timerText.text = timeLeft.ToString("###");
    }

    void Update ()
    {
        if (timeLeft <= 0)
        {
            timeLeft = 0;
            UpdateTimeText();
            return;
        }
        timeLeft -= Time.deltaTime;
        UpdateTimeText();
    }
}
