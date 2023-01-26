using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Vuforia; 

public class TrumpController : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float speed = 4f;
    public DefaultObserverEventHandler imageTargetHandler;
    private Rigidbody rb;
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();


    }

    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");
        bool isShoot = CrossPlatformInputManager.GetButton("Shoot");
        Vector3 movement = new Vector3(x,0, y);
        rb.velocity = movement * speed;
        /*Shoot if the ImageTarget is detected*/
        if(isShoot && imageTargetHandler.GetMObserverBehaviour().TargetStatus.Status == Status.TRACKED){
    //        Debug.Log(imageTargetHandler.GetMObserverBehaviour().TargetStatus.Status);
            Shoot();
        }
        if(x != 0 && y != 0){
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x,y) * Mathf.Rad2Deg , transform.eulerAngles.z);
        }
        if ( x != 0 || y != 0 ){
            anim.Play("walk");
        }
        else{
            anim.Play("idle");
        }
    }
    void Shoot(){
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
