using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health = 5;
    public PlayerHP PlayerHP;
    public float damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            GameManager.Instance.UpdateScore(100);
        }
    }
        private void OnCollisionEnter(Collision other)
    {
        //If I hit something with a rigidbody. . .
        if (other.gameObject.tag == "Player")
        { 
            PlayerHP = other.gameObject.GetComponent<PlayerHP>();
            PlayerHP.health -= damage;
        }
    }
            
            
}
