using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    public float Fuse_length;
    public GameObject explosion;
    public Rigidbody2D rb;

    private float Detonate_time;

    // Start is called before the first frame update
    void Start()
    {
        Detonate_time = Time.time + Fuse_length;
    }

    void Generate_Explosion()
    {
        GameObject a = Instantiate(explosion) as GameObject;
        a.transform.position = rb.position;
    }

    void Explode()
    {
        Debug.Log("Exploded");
        Generate_Explosion();
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Detonate_time)
        {
            Explode();
            Debug.Log("done");
        }
    }

}
