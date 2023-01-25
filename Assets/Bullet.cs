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
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay() called");
        Debug.Log(collision.gameObject.name);

    }
}

