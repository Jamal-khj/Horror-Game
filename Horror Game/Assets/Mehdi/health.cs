using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour
{
    public int hp;
    public int numOFhp;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite EmptyHeart;

  void Update()
    {
        if (hp > numOFhp)
        {
            hp=numOFhp;
        }


        for(int i = 0; i < hearts.Length; i++)
        {
            if (i < hp)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = EmptyHeart; 
            }
            if (i < numOFhp)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy1")
        {
            Destroy(collision.collider.gameObject);
            hp -= 1;
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < hp)
                {
                    hearts[i].enabled = true;
                }
                else
                {
                    hearts[i].enabled = false;
                }
            }
            if (hp <= 0)
            {
                Destroy(gameObject);
                

            }

        }
    }
    }
