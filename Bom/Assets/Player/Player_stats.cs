using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_stats : MonoBehaviour
{
    public Health_bar health_bar;

    public int Current_health;
    public int Max_hearts;
    public int N_hearts;
    public float Damage_cooldown;

    private float Next_interval;


    // Start is called before the first frame update
    void Start()
    {
        Current_health = N_hearts;
        health_bar.Set_N_hearts(N_hearts);
        health_bar.Set_health(Current_health);
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    public void Take_damage(int damage)
    {
        Current_health = Current_health - damage;
        health_bar.Set_health(Current_health);
        if (Current_health == 0)
        {
            Die();
        }

    }

    public void Add_heart()
    {
        if (N_hearts != Max_hearts)
        {
            N_hearts = N_hearts + 1;
            health_bar.Set_N_hearts(N_hearts);
            Current_health = Current_health + 1;
            health_bar.Set_health(Current_health);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Colission is " + col.GetComponent<BoxCollider2D>().name);
        if (col.GetComponent<BoxCollider2D>().name == "Explosion_child")
        {
            Debug.Log("F");
            Take_damage(1);
        }
        if (col.GetComponent<BoxCollider2D>().name == "Laser")
        {
            Debug.Log("F");
            Take_damage(1);
        }
        if (col.GetComponent<BoxCollider2D>().name == "Extra_heart")
        {
            Debug.Log("Heart Up");
            Destroy(col.gameObject);
            Add_heart();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("t") && Time.time > Next_interval)
        {
            Take_damage(1);

            Next_interval = Time.time + Damage_cooldown;

        }
    }
}
