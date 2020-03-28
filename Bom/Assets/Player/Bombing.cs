using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombing : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject bombPrefab;
    public float bomb_cooldown;

    private float NextBomb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Lay_Bomb()
    {
        GameObject a = Instantiate(bombPrefab) as GameObject;
        a.transform.position = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && Time.time > NextBomb)
        {
            Lay_Bomb();

            NextBomb = Time.time + bomb_cooldown;

        }
    }
}
