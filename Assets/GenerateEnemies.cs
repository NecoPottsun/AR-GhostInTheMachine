using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 
public class GenerateEnemies : MonoBehaviour
{
    public float xPos;
    public float zPos;
    public int enemyCount = 0 ;
    public int maxEnemy = 5;
    public GameObject ghostEnemy;
    public DefaultObserverEventHandler imageTargetHandler;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Spawn position : " + transform.position);
        // GameObject newGhost = Instantiate(ghostEnemy, new Vector3(4.3f, 0 ,6.5f), Quaternion.identity);
        // newGhost.transform.parent = transform.parent;
        // newGhost.tag = "Enemy";
    }

    // Update is called once per frame
    void Update(){
        if(imageTargetHandler.GetMObserverBehaviour().TargetStatus.Status == Status.TRACKED){
 //           StartCoroutine(EnemyDrop());
            if(enemyCount < maxEnemy){
                Debug.Log("x = " + imageTargetHandler.transform.position.x + " , z = " + imageTargetHandler.transform.position.z);
                GameObject newGhost = Instantiate(ghostEnemy, new Vector3(transform.position.x, transform.position.y ,transform.position.z) ,Quaternion.identity);
                newGhost.transform.parent = transform.parent;
                Debug.Log("ghost :  x = " + newGhost.transform.position.x + "y = " + newGhost.transform.position.y +" , z = " + newGhost.transform.position.z);
                newGhost.transform.localScale = new Vector3(1,1,1);
               newGhost.transform.eulerAngles = new Vector3(0, -180,0);
               newGhost.transform.localRotation = Quaternion.Euler(0,180,0);
                newGhost.tag = "Enemy";

                enemyCount++;
        
            }

        }
        else{
            // Destroy(GameObject.FindWithTag("Enemy"));
            // enemyCount = 0;
        }
    }
    // IEnumerator EnemyDrop(){
    //     // if(enemyCount < maxEnemy){
    //     //      Debug.Log(enemyCount);
    //     //     xPos = Random.Range(-10f,11f);
    //     //     zPos = Random.RandomRange(-8f,8f);
    //     //     GameObject newGhost = Instantiate(ghostEnemy, new Vector3(xPos, 0 ,zPos), Quaternion.identity);

    //     //     newGhost.transform.parent = transform.parent;
    //     //     newGhost.tag = "Enemy";
    //     //     yield return new WaitForSeconds(0.1f);
    //     //     enemyCount++;
           
    //     // }
    // }

}
