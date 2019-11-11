using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    

    public void OnCollisionEnter(Collision other)
    {
        //When enemy collides with anything, destroy the enemy
        Destroy(gameObject);
        //adds 15 points to main score
        GetComponent<scoreManager>().scoreCount += 15f;
    }

    [SerializeField] private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        if (Camera.main != null) player = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 playerDirection = (player.position - transform.position).normalized;
        transform.Translate(Time.deltaTime * speed * Vector3.back);
    }
}