using UnityEngine;
using TMPro;
public class ScoreBehavior : MonoBehaviour
{
    public EnemyHP EnemyHP;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
    public GameManager Instance;
    void Start()
    {
       GameManager.Instance.UpdateScore();
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("1");
        EnemyHP = other.gameObject.GetComponent<EnemyHP>();
        if (EnemyHP != null)
        {
            Debug.Log("2");
            Score++;
            GameManager.Instance.UpdateScore();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
