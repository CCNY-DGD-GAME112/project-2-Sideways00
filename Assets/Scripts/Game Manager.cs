using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public EnemyHP EnemyHP;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
    public static GameManager Instance;

    public void Awake()
    {
        if (Instance)
        {
            Instance = this;
        }
    }
    public void UpdateScore()
    {
        Debug.Log("3");
        ScoreText.text = "Score: " + Score;
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
