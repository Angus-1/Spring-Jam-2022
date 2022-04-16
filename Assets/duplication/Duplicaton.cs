using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicaton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject player;

    public float offset;
    void Start()
    {
        
        for (var i = 0; i < 2; i++)
        {
            offset = Random.Range(-1.1f, 1.1f);
            Instantiate(prefab, new Vector3(i * player.transform.position.x+ offset, player.transform.position.y+ offset, player.transform.position.z + offset), Quaternion.identity);
        }
    }



      
    void Update()
    {
    
       
    }
}
