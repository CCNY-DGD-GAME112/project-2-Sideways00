using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public EnemyHP EnemyHP;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
    public static GameManager Instance;
    public TextMeshProUGUI GameOvers;
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
        GameOvers.text = "Score: " + Score;
    }
   public GameObject gameOverUI;
   
   public void GameOver()
    {
        gameOverUI.SetActive(true);
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
