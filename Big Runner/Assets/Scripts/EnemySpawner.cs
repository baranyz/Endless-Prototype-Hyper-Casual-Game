using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject sphereHori;
    float spawnTime = 0, randomTime = 0;

    private void Start() {
        
    }
    private void Update() {
        
        spawnTime += Time.deltaTime;
        if(spawnTime > randomTime){
            SpawnSphereHori();
            spawnTime = 0;
            randomTime = Random.Range(0.5f,5f);
        }
    }
    private void SpawnSphereHori(){
        Instantiate(sphereHori, transform.position, Quaternion.identity);
    }
}
