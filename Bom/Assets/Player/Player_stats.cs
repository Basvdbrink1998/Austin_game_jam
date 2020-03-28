using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_stats : MonoBehaviour
{
    public Health_bar health_bar;
    public int Starting_health;

    public int Current_health;

    public float Damage_cooldown;

    private float Next_interval;


    // Start is called before the first frame update
    void Start()
    {
        Current_health = Starting_health;
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    public void Take_damage(int damage)
    {
        Current_health = Current_health - damage;

        if (Current_health < 0)
        {
            Die();
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<BoxCollider2D>().name == "Explosion(Clone)")
        {
            Debug.Log("F");
            Take_damage(1);
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
