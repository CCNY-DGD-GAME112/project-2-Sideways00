using UnityEngine;
using TMPro;


public class ScoreBehavior : MonoBehaviour
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
        UpdateScore();
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("1");
        EnemyHP = other.gameObject.GetComponent<EnemyHP>();
        if (EnemyHP != null) 
        {
            Debug.Log("2");
            Score++;
            UpdateScore();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
