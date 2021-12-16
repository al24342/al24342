using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float spawntime = 2;
    void Start()
    {
        InvokeRepeating("addNewEnemy", 0, spawntime);
    }

    // Update is called once per frame
    void addNewEnemy()
    {
        Renderer rndr = GetComponent<Renderer>();
        var x1 = transform.position.x - rndr.bounds.size.x / 2;
        var x2 = transform.position.x + rndr.bounds.size.x / 2;
        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }
}
