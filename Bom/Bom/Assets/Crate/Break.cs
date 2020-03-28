using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Col " + GetComponent<BoxCollider2D>().gameObject.tag);
        if (GetComponent<BoxCollider2D>().gameObject.tag == "Crate")
        {
            Debug.Log("Break");

            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
