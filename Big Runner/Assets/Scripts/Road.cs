using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] float exitPos, speed;
    float otherObject;
    public static float roadspeed;
    GameObject[] other;
    GameObject single;
    private void Start() {
        
        FindOther();
    }
    private void Update() {

        PosLoop();
        roadspeed = speed*Time.deltaTime;        
    }
    private void FindOther(){
        other = GameObject.FindGameObjectsWithTag("Road");
        for(int i = 0; i < other.Length; i++){
            if(other[i] != this.gameObject) {
                single = other[i];
                break;
            }
        }
    }
    private void PosLoop(){
        transform.Translate(0,0,Time.deltaTime*speed);
        if(transform.position.z < exitPos){
            transform.position = new Vector3(transform.position.x,transform.position.y,
            single.transform.position.z+single.transform.localScale.z);
        }
    }
}
