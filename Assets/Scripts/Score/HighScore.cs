using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    public static HighScore Instance;

    [Header("References")]
    private string highScorePlayerName = "";
    private int highScoreValue ;
    public TextMeshProUGUI highScorePlayerText;
    public TextMeshProUGUI highScoreScoreText;
    private string keyToSaveName = "keyHighScorePlayer";
    private string keyToSaveScore = "keyHighScoreScore";
    public List<PlayerBase> players;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        highScorePlayerText.text = PlayerPrefs.GetString(keyToSaveName, "Sem HighScore");
        if (PlayerPrefs.GetInt(keyToSaveScore) > 0)
        {
            highScoreScoreText.text = PlayerPrefs.GetInt(keyToSaveScore).ToString();
        }
 
    }

    public void CheckHighScore()
    {
        foreach (var player in players)
        {
            if (player.numberOfWins > highScoreValue)
            {
                highScorePlayerName = player.nameText.text;
                highScoreValue = player.numberOfWins;
                PlayerPrefs.SetString(keyToSaveName, highScorePlayerName);
                PlayerPrefs.SetInt(keyToSaveScore, highScoreValue);
   
            }
        }
    }

    public void LeaveGame()
    {
        PlayerPrefs.DeleteAll();
    }


}
