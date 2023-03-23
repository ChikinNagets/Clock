using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class PlayButtonScript : MonoBehaviour
{

    public Button playButton;
    public TimerButtonScript timerButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(callTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Start Timer countdown
    public void callTimer() => timerButton.startTimer(true);
}
