using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointTrigger : MonoBehaviour
{
    public PlayerBase player;
    public string tagCheck = "Ball";
    
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagCheck)
            CountPoint();
    }
   
    private void CountPoint()
    {
        player.AddPoints();
        if (GameManager.Instance.canRespawn)
        {
            GameManager.Instance.RespawnBall();
        }
    }
}
