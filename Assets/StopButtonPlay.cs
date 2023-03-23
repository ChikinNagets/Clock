using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopButtonPlay : MonoBehaviour
{

    public TimerButtonScript timerButton;
    public Button stopButton;
    // Start is called before the first frame update
    void Start()
    {
        stopButton.onClick.AddListener(callTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callTimer() => timerButton.stopTimer(false);
}
