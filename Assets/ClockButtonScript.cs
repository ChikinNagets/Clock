using UnityEngine;
using Button = UnityEngine.UI.Button;

public class ClockButtonScript : MonoBehaviour
{
    public clock clockComponent;
    public Button clockButton;
    public GameObject timerUserInput;

    // Start is called before the first frame update
    void Start()
    {
        // Add event listiner to button
        clockButton.onClick.AddListener(setBooleans);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void setBooleans()
    {
        // Set view booleans
        clockComponent.setBooleans(true, false, false);
        if (timerUserInput.activeSelf)
        {
            timerUserInput.SetActive(false);
        }
    }
 }
