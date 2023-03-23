using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButtonScript : MonoBehaviour
{
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(quitApp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void quitApp() {
        Application.Quit();
    }
}
