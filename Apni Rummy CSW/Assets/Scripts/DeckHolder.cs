using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckHolder : MonoBehaviour
{
    public GameObject deckCards;

    private void Start()
    {
        deckCards.SetActive(false);
        Invoke("ShowDeck", 7);
    }
    void ShowDeck()
    {
        deckCards.SetActive(true);
    }
}
