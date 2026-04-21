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
            Destroy(gameObject);
        }
        Instance = this;
    }

    public void UpdateScore(int point)
    {
        Debug.Log("3");
        Score += point;
        ScoreText.text = "Score: " + Score;
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
