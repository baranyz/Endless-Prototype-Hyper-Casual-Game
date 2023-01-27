using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCone : MonoBehaviour
{
    [SerializeField] float speed;

    private void Start() {
        
        transform.position = new Vector3(Random.Range(-0.48f,0.48f), transform.position.y, transform.position.z);
    }
    private void Update() {
        
        transform.Translate(0,-Road.roadspeed, 0);
    }
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag == "Enemy"){
            Destroy(this.gameObject);
        }
    }
}
