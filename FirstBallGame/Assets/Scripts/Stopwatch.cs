using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Stopwatch : MonoBehaviour
{
    [SerializeField]
    private ScoreScreen _scoreScreen;

    private TimeSpan time;
    
    private bool stopwatchActive = true;
    private float currentTime;
    public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        
        time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
        gameObject.GetComponent<Text>().enabled = false;
    }

    public String getCurrentTimeText()
    {
        return time.ToString(@"mm\:ss\:fff");
    }
}
