using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    void Awake(){
        Destroy(gameObject, life);
    }
    void OnCollisionEnter(Collision collision)
    {   
        Debug.Log("OnCollisionEnter() called");
        Debug.Log(collision.gameObject.tag);
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
            if(collision.gameObject.tag == "Ghost"){
                
            }
            
        }
        Destroy(gameObject);    

    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay() called");
        Debug.Log(collision.gameObject.name);

    }
}

