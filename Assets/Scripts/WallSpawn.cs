using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public GameObject wall;
    int maxWalls;
    public int numofWalls;

    public float spawnRadius = 1F;
    public float spawnCollisionCheckRadius;
    // Start is called before the first frame update
    void Start()
    {
        maxWalls = 3;
        numofWalls = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (numofWalls < maxWalls)
        {
            float chance = Random.Range(0f, 5f);
            if (chance > 4f)
            {
                var position = new Vector3(Random.Range(-6, 6), 1, Random.Range(-7, 7));
                if (!Physics.CheckSphere(position, spawnCollisionCheckRadius))
                {
                    Instantiate(wall, position, Quaternion.identity);
                    numofWalls++;
                }
            }
        }
      

    }
}