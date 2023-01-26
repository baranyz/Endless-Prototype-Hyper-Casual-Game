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
            
            if(touch.position.x > Screen.width/2){
                transform.Translate(HorizontalSpeed*Time.deltaTime,0,0);
            }
            else if(touch.position.x < Screen.width/2){
                transform.Translate(-HorizontalSpeed*Time.deltaTime,0,0);
            }
        }
    }
}
