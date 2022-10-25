using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class Ballmoves : MonoBehaviour
{
    public Rigidbody2D top;
    public float xHiz, yHiz,duvarHiz;
    public TextMeshProUGUI player1Skor,player2Skor,winner,tekraroynayazisi;
    float p1skor, p2skor;
    public float maxskor;
    public AudioSource ballhitsesi, arkaplansesi, oyunbittisesi,sayialmasesi,baslagincüdüksesi;

    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Player1")
        {
            top.velocity = new Vector2(-xHiz, Random.Range(-4, 8f));
            ballhitsesi.Play();
        }
        else if(temas.gameObject.tag == "Player2")
        {
            top.velocity = new Vector2(xHiz, Random.Range(-4, 8));
            ballhitsesi.Play();
        }


        if (temas.gameObject.tag== "Ustduvar")
        {
            top.velocity = new Vector2(top.velocity.x, -yHiz);
        }
        else if(temas.gameObject.tag == "Altduvar")
        {
            top.velocity = new Vector2(top.velocity.x, yHiz);
        }


        if (temas.gameObject.tag == "Solduvar")
        {
            p1skor ++;
            transform.position = new Vector2(6.805f, 0f);
            sayialmasesi.Play();
        }
        else if (temas.gameObject.tag == "Sagduvar")
        {
            p2skor ++;
            transform.position = new Vector2(-6.605f, 0f);
            sayialmasesi.Play();
        }


        if (p1skor == maxskor)
        {
            winner.text = "Roger Federer Win";
            tekraroynayazisi.text = "Press Enter To Play Again";
            oyunbittisesi.Play();
            Time.timeScale = 0;

        }
        else if(p2skor == maxskor)
        {
            winner.text = "Rafael Nadal Win";
            tekraroynayazisi.text = "Press Enter To Play Again";
             
            Time.timeScale = 0;
        }



    }


    void Update()
    {
        if (p1skor == 1)
        {
            player1Skor.text = "15";
        }
        if (p1skor == 2)
        {
            player1Skor.text = "30";
        }
        if (p1skor == 3)
        {
            player1Skor.text = "40";
        }
        if (p2skor == 1)
        {
            player2Skor.text = "15";
        }
        if (p2skor == 2)
        {
            player2Skor.text = "30";
        }
        if (p2skor == 3)
        {
            player2Skor.text = "40";
        }


        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Return)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
            p1skor = 0;
            p2skor = 0;
            


        }

     
    }
}
