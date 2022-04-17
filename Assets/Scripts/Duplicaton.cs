using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicaton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject player;

    public float offset;
    public float spawnAmt = 0;
    void Start()
    {
        
        for (var i = 0; i < spawnAmt; i++)
        {
            offset = Random.Range(-2.5f, 2.5f);
            if (Physics.CheckSphere(new Vector3(player.transform.position.x + offset, player.transform.position.y + offset, 2), 2))
            {
                Instantiate(prefab, new Vector3(player.transform.position.x + offset, player.transform.position.y + offset, 2), Quaternion.identity);

            }
            else
            {
                Instantiate(prefab, new Vector3(player.transform.position.x + 5, player.transform.position.y - 5, 2), Quaternion.identity);
            }
        }
    }



      
    void Update()
    {
        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            spawnAmt = other.GetComponent<WallScript>().wallValue;
            Start();

        }
    }
}
