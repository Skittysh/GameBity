using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody2D rbb;
    public GameObject enemyPrefab;
    public float spawnInterval = 100.5f;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }


    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));

            Vector3 randomOffset = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10));
            GameObject enemyInstance = Instantiate(enemyPrefab, rbb.transform.position + randomOffset, Quaternion.identity);
            enemyInstance.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));
            enemyInstance.transform.localScale += new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f));
            yield return new WaitForSeconds(spawnInterval);


            spawnInterval = Mathf.Max(0.1f, spawnInterval * 1.5f);
        }
    }
}






