using JetBrains.Annotations;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Windows;
using Button = UnityEngine.UI.Button;

public class TimerButtonScript : MonoBehaviour
{
    private const int timerConstant = 15;
    public clock clockComponent;
    public Button timerButton;
    public Button playButton;
    public Button resumeButton;
    public Button stopButton;
    public GameObject timerUserInput;
    public TMP_InputField userInputValue;

    // Start is called before the first frame update
    void Start()
    {
        timerButton.onClick.AddListener(setBooleans);
        timerButton.onClick.AddListener(activateUi);
        userInputValue.onEndEdit.AddListener(TextMeshUpdated);
    }

    // Update is called once per frame
    void Update()
    {

        if (clockComponent.isTimer == true && clockComponent.isTimerOn == true)
        {
            // Update timer value tickdown if isTimer is true
            clockComponent.timeValue -= Time.deltaTime;
        }
        clockComponent.DisplayTime(clockComponent.timeValue);
    }

    private void TextMeshUpdated(String value) 
    {
        if (value != null && Int32.Parse(value) <= timerConstant)
        {
            clockComponent.timeValue = (float)Convert.ToDouble(value);
        }
    }
    private void activateUi()
    {
        if (!timerUserInput.activeSelf)
        {
            timerUserInput.SetActive(true);
        }
    }

    private void setBooleans()
    {
        clockComponent.timeValue = timerConstant;
        clockComponent.setBooleans(false, true, false);
    }

    public void triggerTimer(bool activateCount)
    {
        clockComponent.isTimerOn = activateCount;
    }
}
