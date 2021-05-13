using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScreen : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Stopwatch _stopwatch;

    public void cameraState(bool state)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = state;
        gameObject.GetComponentInChildren<Camera>().enabled = state;
        
        ScoreField();
    }

    public void ScoreField()
    {
        gameObject.GetComponent<TextMeshPro>().text = "FINAL SCORE\n" +
                                                      "Time: " + _stopwatch.getCurrentTimeText() + "\n" +
                                                      "Resets: " + _player.getResetCounter();

    }
}
