using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    int[] nums = { 1, 5, 10};
    public int wallValue;
    GameObject wall;
    WallSpawn spawnerScript;
    int playerCount;
    // Start is called before the first frame update
    void Start()
    {
        wallValue = nums[Random.Range(0, 2)];
        Debug.Log(wallValue);
        wall = GameObject.FindGameObjectWithTag("Spawner");
        spawnerScript = wall.GetComponent<WallSpawn>();
        playerCount = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().numOfClones;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, -5.0f * Time.deltaTime);
        playerCount = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().numOfClones;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Wall"))
            {
                spawnerScript.numofWalls--;
                Destroy(this.gameObject);

            }
            if (gameObject.CompareTag("BadWall") && playerCount == 0)
            {
                Debug.Log("Lol Death");
                GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().Die();
            }
        }
        if (other.CompareTag("Remover"))
        {
            spawnerScript.numofWalls--;
            Destroy(this.gameObject);
        }
    }




}
