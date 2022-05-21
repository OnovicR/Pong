using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public Vector2 speed;
    public bool canMove = false;
    public Vector2 startPos;
   


    private void Start()
    {
        startPos = transform.position;
        RandomSpeed();
    }

    public void RandomSpeed()
    {
        int[] rand = { -1, 1 };
        int randomx = Random.Range(0, 2);
        int randomy = Random.Range(0, 2);


        speed = new Vector2(rand[randomx], rand[randomy]);
       
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            speed.x *= -1;
            speed.x += Mathf.Sign(speed.x);
             
        }
        else
            speed.y *= -1;
    }
    private void Update()
    {
        if(canMove)
            transform.Translate(speed);
    }
}
