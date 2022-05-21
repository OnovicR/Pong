using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("References")]
    public BallBase ball;
    public GameObject startMenu;
    public GameObject endMenu;
    public bool canRespawn = false;
  

    [Header("TimeVariables")]
    public float timeToBallCanMove = 1f;
    

    [Header("PointLimit")]
    public int pointsToFinish = 4;

    private void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        endMenu.SetActive(false);
        RespawnBall();
        canRespawn = true;
    }

    public void RespawnBall()
    {
        ball.transform.position = ball.startPos;
        ball.RandomSpeed();
        ball.canMove = false;
        Invoke("BallCanMove", timeToBallCanMove);
    }

    public void BallCanMove()
    {
        ball.canMove = true;
    }
   
    public void CallScoreMenu()
    {
        endMenu.SetActive(true);
        ball.canMove = false;
        canRespawn = false;
        HighScore.Instance.CheckHighScore();
    }


    // funcao de ir para uma tela de fim de partida que tem  as vezes que cada um ganhou
    // funcao que iniciar nova partida


    // funcao de resetar o game do zero, as partidas que cada um ganhou
    public void ResetGame()
    {
        SceneManager.LoadScene(0);    
    }
  
}
