using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardMechanics : MonoBehaviour
{
    private Image cardImg;
    public int childIndex;

    private void Awake()
    {
        cardImg = GetComponent<Image>();
    }

    public void SetImage(Sprite CardSprite)
    {
        cardImg.sprite = CardSprite;
    }
}
