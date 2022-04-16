using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public GameObject wall;
    int maxWalls;
    public int numofWalls;
    // Start is called before the first frame update
    void Start()
    {
        maxWalls = 5;
        numofWalls = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(numofWalls < maxWalls)
        {
            var position = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            float chance = Random.Range(0f, 5f);
            if (chance > 4f)
            {
                Instantiate(wall, position, Quaternion.identity);
                numofWalls++;
            }

        }
    }
}
