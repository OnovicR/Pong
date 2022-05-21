using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase 
{

    public virtual void OnStateEnter()
    {
        Debug.Log("Enter");
    }

    public virtual void OnStateStay()
    {
        Debug.Log("Stay");
        
    }

    public virtual void OnStateExit()
    {
        Debug.Log("Exit");
    }

    
}

//menu inicial
public class StateMenu : StateBase
{
    public override void OnStateEnter()
    {
        base.OnStateEnter();
        PlayerBase.playerCanMove = false;
    }
}

//estado quando jogando
public class StatePlaying : StateBase
{
    public override void OnStateEnter()
    {
        base.OnStateEnter();
        PlayerBase.playerCanMove = true;
        GameManager.Instance.StartGame();
    }

   
}

// menu tela final
public class StateScoreMenu : StateBase
{
    public override void OnStateEnter()
    {
        base.OnStateEnter();
        PlayerBase.playerCanMove = false;
        GameManager.Instance.CallScoreMenu();
    }
}
// estado de reset game
public class StateReset_Game : StateBase
{
    public override void OnStateEnter()
    {
        base.OnStateEnter();
        GameManager.Instance.ResetGame();
    }
}
