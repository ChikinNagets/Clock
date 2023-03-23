using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class StopwatchButtonScript : MonoBehaviour
{
    public clock clockComponent;
    public Button stopwatchButton;
    public GameObject timerUserInput;
    public TimerButtonScript timerButton;
    public bool stopwatchEnabled;

    // Start is called before the first frame update
    void Start()
    {
        stopwatchButton.onClick.AddListener(setBooleans);
    }

    // Update is called once per frame
    void Update()
    {
        if(clockComponent.isStopwatch == true && clockComponent.isTimerOn == true)
        {
            // Update timer value tickdown if isTimer is true
            clockComponent.timeValue += Time.deltaTime;
            clockComponent.DisplayTime(clockComponent.timeValue);
        }
        
    }

    private void setBooleans()
    {
        clockComponent.timeValue = 0;
        clockComponent.setBooleans(false, false, true);
        if (timerUserInput.activeSelf)
        {
            timerUserInput.SetActive(false);
        }
    }
}
