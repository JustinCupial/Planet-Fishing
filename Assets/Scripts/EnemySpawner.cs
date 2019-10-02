using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject planet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Vector3 spawnPoint = new Vector3(
            Random.Range(-10f,10f),
            Random.Range(2f,10f),
            50f);
        Instantiate(planet, spawnPoint, Quaternion.identity);
    }
}
