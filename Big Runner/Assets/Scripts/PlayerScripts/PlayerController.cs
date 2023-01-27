using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float HorizontalSpeed;
    private void Update() {

        TouchControl();
    }
    private void TouchControl(){
        
        if(Input.touchCount>0){

            Touch touch = Input.GetTouch(0);
            
            if(touch.phase == TouchPhase.Moved){

                transform.position = new Vector3(
                    Math.Clamp(transform.position.x + touch.deltaPosition.x*Time.deltaTime*0.1f,-0.48f,0.48f), transform.position.y, transform.position.z);
            }
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy"){
            //will add gameover stuff
            Debug.Log("GameOver");
        }
    }
}
