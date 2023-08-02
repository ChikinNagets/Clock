using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonScript : MonoBehaviour
{
    public clock clockComponent;
    public Button resetButton;
    public TimerButtonScript timerButton;
    public TMP_InputField userInputValue;

    // Start is called before the first frame update
    void Start()
    {
        resetButton.onClick.AddListener(resetTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void resetTime()
    {
        if (clockComponent.isTimer)
        {
            timerButton.TextMeshUpdated(userInputValue.text);
        } else if (clockComponent.isStopwatch)
        {
            clockComponent.timeValue = 0;
        }
    }
}
