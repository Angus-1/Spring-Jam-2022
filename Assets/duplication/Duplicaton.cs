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
            offset = Random.Range(-2.5f, 2.5f);
            Instantiate(prefab, new Vector3(player.transform.position.x + offset, player.transform.position.y + offset, 2), Quaternion.identity);
        }
    }



      
    void Update()
    {
    
       
    }
}
