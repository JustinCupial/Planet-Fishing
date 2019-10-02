using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Hook : MonoBehaviour
{
    public float speed;
    
    [SerializeField] private Transform anchor;
    [SerializeField] private float strength;
   
    private Vector3 targetPos;
    private Vector3 currentPos;
    private Vector3 velocity;
    private Vector3 lastPos;

    void Update()
    {
        transform.position = Vector3.Lerp(currentPos, targetPos, Time.deltaTime * speed);
        GetVelocity();

        if (VRInput.)
        {
            Release();
        }

        Reel();
    }

    void GetVelocity()
    {
        currentPos = anchor.position;
        velocity = currentPos + lastPos;
        lastPos = currentPos;
    }

    void Release()
    {
        targetPos = anchor + velocity * strength; ?????
    }

    void Reel()
    {
        targetPos = Vector3.Lerp(targetPos, anchor.position,?????);
    }
}
