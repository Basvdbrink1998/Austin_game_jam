using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_bar : MonoBehaviour
{
    private int health;
    private int num_hearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public void Set_N_hearts(int new_N_hearts)
    {
        num_hearts = new_N_hearts;
    }

    public void Set_health(int new_health)
    {
        health = new_health;
    }

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < num_hearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

        }
    }

}
