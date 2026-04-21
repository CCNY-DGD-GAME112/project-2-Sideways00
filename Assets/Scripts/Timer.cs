using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 180.0f;
    public TextMeshProUGUI timerText;
    

    private int _decimals;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining < 0) return;
        timeRemaining -= Time.deltaTime;
        if (timeRemaining < 0){ 
            timeRemaining = 0;
            GameManager.Instance.GameOver();
        }   
        UpdateText();
    }
    void UpdateText()
    {
        timerText.text = timeRemaining.ToString($"F{_decimals}");
    }
}
