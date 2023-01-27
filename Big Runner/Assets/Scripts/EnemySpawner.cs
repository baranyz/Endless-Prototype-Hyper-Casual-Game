using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject sphereHori, cone;
    Vector3 randomPos;
    float spawnTimeSphere = 0, randomTimeSphere = 0;
    float spawnTimeCone = 0, randomTimeCone = 0;

    private void Update() {
        
        randomPos = new Vector3(Random.Range(-0.4f,0.4f), transform.position.y, transform.position.z);
        SpawnAll();
    }
    private void SpawnAll(){

        spawnTimeSphere += Time.deltaTime;
        if(spawnTimeSphere > randomTimeSphere){
            SpawnSphereHori();
            spawnTimeSphere = 0;
            randomTimeSphere = Random.Range(2.5f,20f);
        }

        spawnTimeCone += Time.deltaTime;
        if(spawnTimeCone > randomTimeCone){
            SpawnCone();
            spawnTimeCone = 0;
            randomTimeCone = Random.Range(2.5f,20f);
        }

    }
    private void SpawnSphereHori(){
        Instantiate(sphereHori, randomPos, Quaternion.identity);
    }
    private void SpawnCone(){
        Instantiate(cone);
    }
}
