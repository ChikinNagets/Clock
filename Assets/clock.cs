using System.Globalization;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class clock : MonoBehaviour
{
    // Get Format to use
    public string myFormat;

    // Instantiate the Text Pro Object
    public TMP_Text clockText;

    // Get current time and date
    public System.TimeSpan timeSpan = new System.TimeSpan(0, 0, 0, 0, 0);
    public System.DateTime date = System.DateTime.Now;
    public float timeRate = 1;

    // Set Value for timer count down
    public string displayValue;
    public float timeValue;
    public bool isClock = true;
    public bool isTimer;
    public bool isStopwatch;
    public Button playButton;
    public Button stopButton;
    public Button resetButton;

    public bool isTimerOn = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        // Check boolean to display clock, timer or stopwatch
        if(isClock == true)
        {
            // Get milliseconds to count
            float milliseconds = Time.deltaTime * 1000 * timeRate;


            // Get time span 
            timeSpan += new System.TimeSpan(0, 0, 0, 0, (int)milliseconds);
            System.DateTime dateTime = date.Add(timeSpan);

            // Display date and time in correct format
            displayValue = dateTime.ToString(myFormat.Replace(" ", "\n"), new CultureInfo("en-US"));
        }
        clockText.text = displayValue;

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    public void DisplayTime(float timeToDisplay)
    {
        // Get second, minutes and milliseconds for timer and stopwatch
        float Minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float Seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float MilleSeconds = timeToDisplay % 1 * 1000;

        // Display timer and stopwatch in correct format
        displayValue = string.Format("{0:00}:{1:00}:{2:00}", Minutes, Seconds, MilleSeconds);
    }
    public void setBooleans(bool clockBool, bool timerBool, bool stopwatchBool)
    {
        isClock = clockBool;
        isTimer = timerBool;
        isStopwatch = stopwatchBool;

        if (!isClock)
        {
            playButton.gameObject.SetActive(true);
            stopButton.gameObject.SetActive(true);
            resetButton.gameObject.SetActive(true);
        } else
        {
            playButton.gameObject.SetActive(false);
            stopButton.gameObject.SetActive(false);
            resetButton.gameObject.SetActive(false);
        }
    }
}
