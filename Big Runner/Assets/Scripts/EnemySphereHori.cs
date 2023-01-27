using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySphereHori : MonoBehaviour
{
    float direct = 1;
    [SerializeField] float speed, moveSpeed, deathTime = 0;
    Rigidbody rgb;

    private void Start() {
        
        rgb = GetComponent<Rigidbody>();
    }

    private void Update() {

        transform.Translate(0,0,moveSpeed*Time.deltaTime);
        rgb.velocity = new Vector3(direct*speed,0,0);

        deathTime += Time.deltaTime;
        if(deathTime>30) Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Barrier"){
            direct *= -1;
        }
    }
}
