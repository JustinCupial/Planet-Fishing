using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollow : MonoBehaviour
{

    Vector3 offset;
    [SerializeField]
    float offsetMagnitude;
    [SerializeField]
    private float lerpSpeed;
    private Transform target;
   // private RectTransform r_t;
    
    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.transform;
        //r_t = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Choose the speed at which the UI travels
        offset = target.forward * offsetMagnitude;
        
        //Set a transform for where the UI will sit
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * lerpSpeed);
        
        //UI always looks at you
        transform.LookAt(target);
    }
}
