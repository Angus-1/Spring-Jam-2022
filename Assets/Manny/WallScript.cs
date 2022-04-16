using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    int[] nums = { 1, 5, 10, 20, 30 };
    int wallValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wallValue = nums[Random.Range(0, 5)];
        Debug.Log(wallValue);
    }
}
