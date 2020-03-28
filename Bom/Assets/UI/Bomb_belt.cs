using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb_belt : MonoBehaviour
{
    public int current_bombs;
    public int num_bombs;

    public Image[] bombs;
    public Sprite fullBomb;
    public Sprite emptyBomb;

    public void Set_N_bombs(int new_N_bombs)
    {
        num_bombs = new_N_bombs;
    }

    public void Set_bombs(int new_bombs)
    {
        current_bombs = new_bombs;
    }

    void Update()
    {
        for (int i = 0; i < bombs.Length; i++)
        {
            if (i < current_bombs)
            {
                bombs[i].sprite = fullBomb;
            }
            else
            {
                bombs[i].sprite = emptyBomb;
            }
            if (i < num_bombs)
            {
                bombs[i].enabled = true;
            }
            else
            {
                bombs[i].enabled = false;
            }

        }
    }

}
