using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombing : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject bombPrefab;
    public Bomb_belt bomb_belt;
    public float bomb_cooldown;
    public int starting_N_bombs;
    public int Max_bombs;

    private int current_max_bombs;
    private int N_bombs_left;
    private float NextBomb;

    // Start is called before the first frame update
    void Start()
    {
        bomb_belt.Set_N_bombs(starting_N_bombs);
        bomb_belt.Set_bombs(starting_N_bombs);
        current_max_bombs = starting_N_bombs;
        N_bombs_left = starting_N_bombs;
    }

    void Lay_Bomb()
    {
        GameObject a = Instantiate(bombPrefab) as GameObject;
        Debug.Log((this.transform.forward).normalized);
        a.transform.position = rb.position;

        N_bombs_left = N_bombs_left - 1;

        bomb_belt.Set_bombs(N_bombs_left);
    }

    public void Add_bomb()
    {
        if (current_max_bombs != Max_bombs)
        {
            current_max_bombs = current_max_bombs + 1;
            bomb_belt.Set_N_bombs(current_max_bombs);
            N_bombs_left = N_bombs_left + 1;
            bomb_belt.Set_bombs(N_bombs_left);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<BoxCollider2D>().name == "Bomb_bag")
        {
            Destroy(col.gameObject);
            Add_bomb();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && Time.time > NextBomb && N_bombs_left > 0)
        {
            Lay_Bomb();

            NextBomb = Time.time + bomb_cooldown;

        }
    }
}
