using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform mTarget;
    float mSpeed = 10.0f;
    Vector3 mLookDirection;
    const float EPSILON = 0.2f;
    
 
    void Start()
    {
       mTarget = GameObject.Find("Player").transform;
    }


    void Update()
    {
        mLookDirection = (mTarget.position - transform.position).normalized;

        if ((transform.position - mTarget.position).magnitude > EPSILON)
            transform.Translate(mLookDirection * Time.deltaTime * mSpeed);
    }

}
