using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed;

    Rigidbody rb;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    private void FixedUpdate()
    {
        if(Vector2.Distance(player.transform.position, transform.position) >= 2.0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);

        }
    }
}
