using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public EnemyHP EnemyHP;
    public int Score = 0;
    public TextMeshPro ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void UpdateScore()
    {
        Debug.Log("3");
        ScoreText.text = "Score: " + Score;
    }
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
