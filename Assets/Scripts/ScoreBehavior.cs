using UnityEngine;
using TMPro;


public class ScoreBehavior : MonoBehaviour
{
    public EnemyHP EnemyHP;
    public int Score = 0;
    public TextMeshPro ScoreText;
    public GameManager GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Start()
    {
        GameManager.UpdateScore();
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("1");
        EnemyHP = other.gameObject.GetComponent<EnemyHP>();
        if (EnemyHP != null) 
        {
            Debug.Log("2");
            Score++;
            GameManager.UpdateScore();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
