using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPElement : MonoBehaviour
{
    [SerializeField]
    private Image playerImg;
    [SerializeField]
    private Image healthBar;

    public void setPlayerImage(Sprite img)
    {
        playerImg.sprite = img;
    }

    public void setHealthBar(float amount,Color barColor)
    {
        healthBar.fillAmount = amount;
        healthBar.color = barColor;
    }


}
