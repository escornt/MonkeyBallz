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
    private OutOfBound oob;
    void Start ()
    {
        oob = GameObject.FindGameObjectWithTag("OOB").GetComponent<OutOfBound>();
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
            timeLeft = minute * 60 + second;
            UpdateTimeText();
            oob.killPlayer();
            return;
        }
        timeLeft -= Time.deltaTime;
        UpdateTimeText();
    }
}
