using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text MyText;
    public int cloneNum;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "Number of Followers: ";
        cloneNum = GameObject.Find("Player").GetComponent<Movement>().numOfClones;
}

    // Update is called once per frame
    void Update()
    {
        MyText.text = "Number of Followers: ";
        cloneNum = GameObject.Find("Player").GetComponent<Movement>().numOfClones;
    }
}
