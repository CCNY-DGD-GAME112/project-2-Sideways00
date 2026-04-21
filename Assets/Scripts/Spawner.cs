using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    public void SpawnObject()
    {
        Instantiate(Enemy,transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }

    // Update is called once per frame
    
}
