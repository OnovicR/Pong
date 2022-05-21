using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorButtomBase : MonoBehaviour
{
    public Color selectedColor;
    public PlayerBase player;
    public Image image;
    public TextMeshProUGUI nameColor;

    public void ChangeColor()
    {
        selectedColor = image.color;
        player.imageColor.color = selectedColor;
        nameColor.color = selectedColor;

    }
}
