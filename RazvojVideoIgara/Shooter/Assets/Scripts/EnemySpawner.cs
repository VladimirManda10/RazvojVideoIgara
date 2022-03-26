using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<Transform> spawnPoints = new List<Transform>();
    public PlayerMovement player;
    public List<GameObject> Enemies; 
    public int maxEnemyCount;
    private int enemyCount;

    private float timeForSpawn;
    public void Awake() 
    {
        enemyCount = 0;
        timeForSpawn = 2f;
        Enemies = new List<GameObject>();
    }
    void Start()
    {
        StartCoroutine(spawnCoroutine(timeForSpawn));
    }

    void Update()
    {
        
    }

    public IEnumerator spawnCoroutine(float timeForSpawn)
    {
        System.Random random = new System.Random();
        while (true)
        {
            int index = random.Next(0, spawnPoints.Count);
            GameObject instance = Instantiate(enemyPrefab,spawnPoints[index].position, Quaternion.identity);
            Enemies.Add(instance);
            enemyCount++;
            Enemy enemy = instance.GetComponent<Enemy>();
            enemy.player = player.gameObject;
            
            if(enemyCount >= maxEnemyCount)
                yield break;

            yield return new WaitForSecondsRealtime(timeForSpawn);

        }
    }

}
