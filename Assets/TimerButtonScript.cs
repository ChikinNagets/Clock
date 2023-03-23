using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class TimerButtonScript : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        if (clockComponent.isTimer == true && clockComponent.isTimerOn == true)
        { 
            // Update timer value tickdown if isTimer is true
            clockComponent.timeValue -= Time.deltaTime;
            clockComponent.DisplayTime(clockComponent.timeValue);
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
        clockComponent.timeValue = 15;
        clockComponent.setBooleans(false, true, false);
        clockComponent.isTimerOn = true;
    }

    public void startTimer(bool activateCount)
    {
        clockComponent.isTimerOn = activateCount;
    }

    public void stopTimer(bool deactivateCount)
    {
        clockComponent.isTimerOn = deactivateCount;
    }
}
