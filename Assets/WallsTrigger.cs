using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsTrigger : MonoBehaviour
{
    public GameObject cube;
    public GameObject character_position;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void triggerWalls(){
        GameObject cloneWall = Instantiate(cube, character_position.transform.position, character_position.transform.rotation);
    }
}
