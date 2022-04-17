using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform mTarget;
    float mSpeed = 5.0f;
    Vector3 mLookDirection;
    const float EPSILON = 2.5f;
    
 
    void Start()
    {
       mTarget = GameObject.Find("Player").transform;
       mTarget.GetComponent<Movement>().numOfClones++;
    }


    void FixedUpdate()
    {
        mLookDirection = (mTarget.position - transform.position).normalized;

        if ((transform.position - mTarget.position).magnitude > EPSILON)
            transform.Translate(mLookDirection * Time.deltaTime * mSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BadWall"))
        {
            mTarget.GetComponent<Movement>().numOfClones--;
            Destroy(this.gameObject);

        }
    }

    

}
