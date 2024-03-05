using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float startTime = 120f;
    public Text countdownText;

    private float currentTime;
    

    void Start()
    {
        currentTime = startTime;

        
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 0)
        {
            currentTime = 0;

            SceneManager.LoadSceneAsync(2);
        }

        UpdateCountdownText();
    }

    void UpdateCountdownText()
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
