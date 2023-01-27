using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySphereHori : MonoBehaviour
{
    float direct = 1;
    [SerializeField] float speed;
    Rigidbody rgb;

    private void Start() {
        
        rgb = GetComponent<Rigidbody>();
    }

    private void Update() {

        transform.Translate(0,0,Road.roadspeed);
        rgb.velocity = new Vector3(direct*speed,0,0);

        
    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Barrier"){
            direct *= -1;
        }
    }
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag == "Enemy"){
            Destroy(this.gameObject);
        }
    }
}
