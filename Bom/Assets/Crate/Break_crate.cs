﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_crate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Triggered");
        if (col.GetComponent<BoxCollider2D>().name == "Explosion_child")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
