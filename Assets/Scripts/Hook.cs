using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Hook : MonoBehaviour
{
    public float speed;
    public float reelSpeed;
    
    [SerializeField] private Transform anchor;
    [SerializeField] private float strength = 5;
    [SerializeField] private float distanceThreshhold = 2;
    
    private Vector3 targetPos;
    private static Vector3 currentPos;
    private Vector3 velocity;
    private Vector3 lastPos;
    private Queue <Vector3> velArch = new Queue<Vector3>();
    private float archSize = 5;
    private float _scalar = 1f;

    void Update()
    {
        transform.position = Vector3.Lerp(currentPos, targetPos,  speed * Time.deltaTime);
        
        float _dotProduct = Vector3.Dot(anchor.position, currentPos);
        //possible range = (-1,1)... clamping ()
        _scalar = (Mathf.Clamp(_dotProduct, .1f, 1f) * reelSpeed);
        
        if (VRInput.GetUp(VRButton.RightIndex))
        {
            //if distance is close... Release
            if (anchor.Distance(targetPos) < distanceThreshhold)
            {
                Release();
            }
        }
        Reel();
    }

    /*[SerializeField] private float val, min, max;


    [ContextMenu("Test")]
    public void Test()
    {
        print(Clamp(val, min, max));
    }
    
        
    public float Clamp(float value, float min, float max)
    {

        if (value < min)
        {
            return min;
        } else if (value > max)
        {
            return max;
        }
        else
        {
            return value;
        }
        
    }*/

    private void FixedUpdate()
    {
        GetVelocity();

    }

    void GetVelocity()
    {
        currentPos = anchor.position;
        if (velArch.Count > archSize)
        {
            velArch.Dequeue();
        }
        velArch.Enqueue(currentPos - lastPos);
        velocity = AvgVector3(velArch);
        lastPos = currentPos;
        print("Velocity: " + velocity);
    }

    private Vector3 AvgVector3(IEnumerable<Vector3> vectorList)
    {
        Vector3 sum = new Vector3();

        foreach (Vector3 v3 in vectorList)
        {
            sum += v3;
        }

        return sum / archSize;
    }
    
    public void Release()
    {
        print("releasing with velocity: " + velocity);
        
       targetPos = (anchor.position + velocity * strength);
       
       print("Target pos after release: " + targetPos);
      // Debug.Break();
    }
    
    void Reel()
    {
      targetPos = Vector3.Lerp(targetPos, anchor.position, _scalar * Time.deltaTime);
      //print("Reeling in, target pos is: " + targetPos );
      print("Reeling in at: " + _scalar);
    }

}


