using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidBody;
    [SerializeField]
    private ScoreScreen _scoreScreen;
    [SerializeField]
    private Stopwatch _stopWatch;
    Vector3 originalPos;
    
    private int resetCounter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var inputAxis = Input.GetAxis("Horizontal");
        
        _rigidBody.AddForce(new Vector3(inputAxis*2,0,0));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            resetCounter++;
            Debug.Log(resetCounter);
            gameObject.transform.position = originalPos;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            _stopWatch.StopStopwatch();
            _scoreScreen.cameraState(true);
        }
    }
    public int getResetCounter()
    {
        return this.resetCounter;
    }
}
