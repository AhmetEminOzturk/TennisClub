using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float karakter1hiz;
    public float yPozisyon;
   
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f,karakter1hiz * Time.deltaTime,0f);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f,-karakter1hiz * Time.deltaTime,0f);
        }
        yPozisyon = Mathf.Clamp(transform.position.y, -3.14f, 3.14f);
        transform.position = new Vector2(transform.position.x, yPozisyon);
    }
}
