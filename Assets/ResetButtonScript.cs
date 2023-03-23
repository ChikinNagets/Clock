using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonScript : MonoBehaviour
{

    public Button resetButton;
    public clock clockComponent;

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
            clockComponent.timeValue = 15;
        } else if (clockComponent.isStopwatch)
        {
            clockComponent.timeValue = 0;
        }
    }
}
