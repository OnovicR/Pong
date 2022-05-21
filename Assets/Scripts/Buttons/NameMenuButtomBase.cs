using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameMenuButtomBase : MonoBehaviour
{
    public TextMeshProUGUI uiTextInput;
    public TextMeshProUGUI uiTextName;
    public PlayerBase player;


    public void AcceptNameInput()
    {
        uiTextName.text = uiTextInput.text;
        player.nameText.text = uiTextName.text;
        player.nameEndText.text = uiTextName.text;
    }


}
