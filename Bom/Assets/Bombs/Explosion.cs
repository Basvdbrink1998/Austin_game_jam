using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float Explosion_length;

    private float Finish_time;

    // Start is called before the first frame update
    void Start()
    {
        Finish_time = Time.time + Explosion_length;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Finish_time)
        {
            Debug.Log("Explosion_done" + Finish_time + "from" + Time.time);
            Destroy(this.gameObject);
        }
    }
}
