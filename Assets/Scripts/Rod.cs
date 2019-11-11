

using System;
#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod : MonoBehaviour
{

    [SerializeField] private float mouseSpeed;

    private Vector2 mouseCur, mouseOld, mouseDelta;

    private Hook hook;

    private void Start()
    {
        hook = FindObjectOfType<Hook>();
    }

    // Update is called once per frame
    void Update()
    {

        /*mouseCur = Input.mousePosition;
        mouseDelta = mouseCur - mouseOld;
        mouseOld = mouseCur;
        
        transform.Rotate(mouseDelta * Time.deltaTime * mouseSpeed);

        if (Input.GetMouseButtonDown(0))
        {
            hook?.Release();
        }
        
        transform.position = Vector3.zero;
        Camera.main.transform.LookAt(this.transform);*/
        
    }
    
}
#endif
