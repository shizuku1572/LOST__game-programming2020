﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{
    public float Time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("haha");
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("hehehe");
            Destroy(gameObject, Time);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("haha");
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("hehehe");
            Destroy(gameObject, Time);
        }
    }
}
