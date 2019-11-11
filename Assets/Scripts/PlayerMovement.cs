using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0 );
        transform.Translate(0,0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
