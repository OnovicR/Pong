using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerBase : MonoBehaviour
{
    [Header ("KeyInputs")]
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;

    [Header ("Points")]
    public int currentPoints = 0;
    public int numberOfWins;
    public TextMeshProUGUI points;
    public TextMeshProUGUI wins;
    

    [Header("Color")]
    public Image imageColor;

    [Header("Name")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI nameEndText;

    public static bool playerCanMove = false;
    public int speed = 15;
    public Rigidbody2D myrigidbody2D;

    private void Move()
    {
        if (Input.GetKey(moveUp))
            {
            myrigidbody2D.MovePosition(transform.position + transform.up * speed);
            }
        else if (Input.GetKey(moveDown))
            {
            myrigidbody2D.MovePosition(transform.position + transform.up * -speed);
            }
    }

    public void GameEnd()
    {
        numberOfWins++;
        currentPoints = 0;
        wins.text = $"{numberOfWins}";
        points.text = $"Pontos:{currentPoints}";
    }

    public void AddPoints()
    {
        currentPoints++;
        points.text = $"Pontos:{currentPoints}";
        if(currentPoints >= GameManager.Instance.pointsToFinish)
        {
            GameEnd();
            StateMachine.Instance.CallSwitch(StateMachine.States.Score);
        }
       
    }

    
    private void ResetWins()
    {
        
    }

    void Update()
    {
        if(playerCanMove)
            Move();
    }

    private void Start()
    {
        points.text = $"Pontos:{currentPoints}";
    }
}
