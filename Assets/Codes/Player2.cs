using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float karakter2hiz;
    public float yPozisyon;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f,karakter2hiz* Time.deltaTime,0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f,-karakter2hiz * Time.deltaTime,0f);
        }
        yPozisyon = Mathf.Clamp(transform.position.y, -3.14f, 3.14f);
        transform.position = new Vector2 (transform.position.x, yPozisyon);
    }
}
