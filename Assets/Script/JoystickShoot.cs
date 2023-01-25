using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickShoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0; 
        while(i < Input.touchCount){
            Touch t = Input.GetTouch(i);
            if(t.phase == TouchPhase.Began){
                if(t.position.x > Screen.width/2){
                    shootBullet();
                }
            }
        }       
    }
    void shootBullet(){
        Debug.Log("Fire");
    }
}
