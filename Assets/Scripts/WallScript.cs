using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    int[] nums = { 1, 5, 10};
    public int wallValue;
    GameObject wall;
    WallSpawn spawnerScript;
    // Start is called before the first frame update
    void Start()
    {
        wallValue = nums[Random.Range(0, 2)];
        Debug.Log(wallValue);
        wall = GameObject.FindGameObjectWithTag("Spawner");
        spawnerScript = wall.GetComponent<WallSpawn>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, -5.0f * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Remover") || other.CompareTag("Player"))
        {
            spawnerScript.numofWalls--;
            Destroy(this.gameObject);
        }
    }




}
