using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum States
    {
        Menu,
        Playing,
        Score,
        Reset_Game
    }

    public static StateMachine Instance;

    public Dictionary<States, StateBase> StateDictionary;
    private StateBase currentState;

    
    private void Awake()
    {
        Instance = this;
        StateDictionary = new Dictionary<States, StateBase>();
        StateDictionary.Add(States.Menu, new StateMenu());
        StateDictionary.Add(States.Playing, new StatePlaying());
        StateDictionary.Add(States.Score, new StateScoreMenu());
        StateDictionary.Add(States.Reset_Game, new StateReset_Game());

        currentState = StateDictionary[States.Menu];
    }

    private void SwitchState(States state)
    {
        if (currentState != null)
            currentState.OnStateExit();

        currentState = StateDictionary[state];
        currentState.OnStateEnter();
    }

    public void CallSwitch(States state)
    {
        SwitchState(state);
    }

    
    void Update()
    {
        if (currentState != null)
        {
            currentState.OnStateStay();
            Debug.Log(currentState);
        }

       

        if (Input.GetKey(KeyCode.E))
            SwitchState(States.Reset_Game);
            
    }

   
}
