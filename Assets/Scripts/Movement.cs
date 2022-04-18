using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider bc;
    Vector3 moveXMent;
    public float speed;
    public float jumpVel;
    public AudioClip jump;
    public AudioClip death;
    public AudioSource camSpeaker;

    bool alive = true;
    public int numOfClones = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (alive) { playerMove(); }
        
        
    }

    public void Die()
    {
        if(numOfClones == 0)
        {
            alive = false;
            SceneManager.LoadScene(0);

        }
    }

   

    void playerMove()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        moveXMent = new Vector3(moveX, 0, moveY);
        transform.Translate(moveXMent * speed * Time.deltaTime, Space.World);
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(bc.bounds.center, transform.TransformDirection(Vector3.down), 5))
        {
            camSpeaker.clip = jump;
            camSpeaker.Play();
            rb.velocity = Vector3.up * jumpVel;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BadWall") && numOfClones == 0)
        {
            Die();
        }
    }

}
