using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtomBase : MonoBehaviour
{

    public void CallStatePlay()
    {
        StateMachine.Instance.CallSwitch(StateMachine.States.Playing);
    }

    public void CallStateReset()
    {
        StateMachine.Instance.CallSwitch(StateMachine.States.Reset_Game);
    }

    public void CallLeave()
    {
        HighScore.Instance.LeaveGame();
        SceneManager.LoadScene(0);
    }
}
