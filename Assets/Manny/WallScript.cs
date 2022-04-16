using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    int[] nums = { 1, 5, 10, 20, 30 };
    int wallValue;
    GameObject Wall;
    WallSpawn spawnerScript;
    // Start is called before the first frame update
    void Start()
    {
        wallValue = nums[Random.Range(0, 5)];
        Debug.Log(wallValue);
        Wall = GameObject.FindGameObjectWithTag("Spawner");
        spawnerScript = Wall.GetComponent<WallSpawn>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, -5.0f * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnerScript.numofWalls--;
    }

}
