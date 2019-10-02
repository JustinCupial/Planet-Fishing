using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEditor.UIElements;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }

    [SerializeField] private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        player = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 playerDirection = (player.position - transform.position).normalized;
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}