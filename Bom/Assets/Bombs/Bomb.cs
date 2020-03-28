using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    public float Fuse_length;
    public GameObject explosion;
    public Rigidbody2D rb;
    private BoxCollider2D myCol;

    private float Detonate_time;

    // Start is called before the first frame update
    void Start()
    {
        Detonate_time = Time.time + Fuse_length;
        myCol = GetComponent<BoxCollider2D>();
        myCol.isTrigger = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.GetComponent<CapsuleCollider2D>().name == "Player")
        {
            myCol.isTrigger = false;
        }
    }

    void Generate_Explosion()
    {
        GameObject a = Instantiate(explosion) as GameObject;
        a.transform.position = rb.position;
    }

    void Explode()
    {
        Generate_Explosion();
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Detonate_time)
        {
            Explode();
        }
    }

}
