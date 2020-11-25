using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RummyMechanics : MonoBehaviour
{
    public GameObject cardsInHand;
    public GameObject WonUI;
    public GameObject BlurImage;

    private int noCards;

    private bool Sets = false;
    private bool Runs = false;

    private void Start()
    {
        int noPlayers = PlayerPrefs.GetInt("Players");

        if (noPlayers == 2)
        {
            noCards = 13;
        }

        if (noPlayers == 3)
        {
            noCards = 9;
        }

        if (noPlayers == 4)
        {
            noCards = 7;
        }
    }
    private void Update()
    {
        checkRummy();
        if(Sets == true)
        {
            if (Runs == true)
            {
                if(cardsInHand.transform.childCount == noCards)
                {
                    BlurImage.SetActive(true);
                    WonUI.SetActive(true);
                }
            }
        }
    }

    #region 13Cards
    void checkSetsfor13()
    {
        string cardName= cardsInHand.transform.GetChild(0).GetComponent<Image>().sprite.name;

        if (cardName.Contains("A"))
        {
            string cardFace = "A";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("2"))
        {
            string cardFace = "2";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {                       
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("3"))
        {
            string cardFace = "3";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {   
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("4"))
        {
            string cardFace = "4";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {       
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("5"))
        {
            string cardFace = "5";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {              
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("6"))
        {
            string cardFace = "6";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {                       
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("7"))
        {
            string cardFace = "7";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {                       
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("8"))
        {
            string cardFace = "8";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {         
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("9"))
        {
            string cardFace = "9";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {              
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("10"))
        {
            string cardFace = "10";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    { 
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("J"))
        {
            string cardFace = "J";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {     
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("Q"))
        {
            string cardFace = "Q";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {
                        Sets = true;
                    }
                }
            }
        }
        if (cardName.Contains("K"))
        {
            string cardFace = "K";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardFace))
                    {
                        Sets = true;
                    }
                }
            }
        }
    }
    void checkRunsfor13()
    {
        string suit = cardsInHand.transform.GetChild(4).GetComponent<Image>().sprite.name;

        if (suit.Contains("Clover"))
        {
            string cardSuit = "Clover";

            int i = 5;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                if (cardsInHand.transform.GetChild(i + 5).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                {
                                    if (cardsInHand.transform.GetChild(i + 6).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                    {
                                        if (cardsInHand.transform.GetChild(i + 7).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                        {
                                            checkRunOrder13();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        if (suit.Contains("Diamonds"))
        {
            string cardSuit = "Diamonds";

            int i = 5;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                if (cardsInHand.transform.GetChild(i + 5).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                {
                                    if (cardsInHand.transform.GetChild(i + 6).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                    {
                                        if (cardsInHand.transform.GetChild(i + 7).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                        {
                                            checkRunOrder13();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (suit.Contains("Hearts"))
        {
            string cardSuit = "Hearts";

            int i = 5;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                if (cardsInHand.transform.GetChild(i + 5).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                {
                                    if (cardsInHand.transform.GetChild(i + 6).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                    {
                                        if (cardsInHand.transform.GetChild(i + 7).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                        {
                                            checkRunOrder13();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (suit.Contains("Spade"))
        {
            string cardSuit = "Spade";

            int i = 5;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                if (cardsInHand.transform.GetChild(i + 5).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                {
                                    if (cardsInHand.transform.GetChild(i + 6).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                    {
                                        if (cardsInHand.transform.GetChild(i + 7).GetComponent<Image>().sprite.name.Contains(cardSuit))
                                        {
                                            checkRunOrder13();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    void checkRunOrder13()
    {
        string suitNo = cardsInHand.transform.GetChild(4).GetComponent<Image>().sprite.name;
        int index = 5;

        if (suitNo.Contains("A"))
        {
            if(cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("2"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("3"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("4"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("5"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("6"))
                            {
                                if (cardsInHand.transform.GetChild(index + 5).GetComponent<Image>().sprite.name.Contains("7"))
                                {
                                    if (cardsInHand.transform.GetChild(index + 6).GetComponent<Image>().sprite.name.Contains("8"))
                                    {
                                        if (cardsInHand.transform.GetChild(index + 7).GetComponent<Image>().sprite.name.Contains("9"))
                                        {
                                            Runs = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("2"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("3"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("4"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("5"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("6"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("7"))
                            {
                                if (cardsInHand.transform.GetChild(index + 5).GetComponent<Image>().sprite.name.Contains("8"))
                                {
                                    if (cardsInHand.transform.GetChild(index + 6).GetComponent<Image>().sprite.name.Contains("9"))
                                    {
                                        if (cardsInHand.transform.GetChild(index + 7).GetComponent<Image>().sprite.name.Contains("10"))
                                        {
                                            Runs = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("3"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("4"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("5"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("6"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("7"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("8"))
                            {
                                if (cardsInHand.transform.GetChild(index + 5).GetComponent<Image>().sprite.name.Contains("9"))
                                {
                                    if (cardsInHand.transform.GetChild(index + 6).GetComponent<Image>().sprite.name.Contains("10"))
                                    {
                                        if (cardsInHand.transform.GetChild(index + 7).GetComponent<Image>().sprite.name.Contains("J"))
                                        {
                                            Runs = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("4"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("5"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("6"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("7"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("8"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("9"))
                            {
                                if (cardsInHand.transform.GetChild(index + 5).GetComponent<Image>().sprite.name.Contains("10"))
                                {
                                    if (cardsInHand.transform.GetChild(index + 6).GetComponent<Image>().sprite.name.Contains("J"))
                                    {
                                        if (cardsInHand.transform.GetChild(index + 7).GetComponent<Image>().sprite.name.Contains("Q"))
                                        {
                                            Runs = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("5"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("6"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("7"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("8"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("9"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("10"))
                            {
                                if (cardsInHand.transform.GetChild(index + 5).GetComponent<Image>().sprite.name.Contains("J"))
                                {
                                    if (cardsInHand.transform.GetChild(index + 6).GetComponent<Image>().sprite.name.Contains("Q"))
                                    {
                                        if (cardsInHand.transform.GetChild(index + 7).GetComponent<Image>().sprite.name.Contains("K"))
                                        {
                                            Runs = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    #endregion

    #region 9Cards
    void checkSetsfor9()
    {
        string cardName = cardsInHand.transform.GetChild(0).GetComponent<Image>().sprite.name;

        if (cardName.Contains("A"))
        {
            string cardFace = "A";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("2"))
        {
            string cardFace = "2";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("3"))
        {
            string cardFace = "3";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("4"))
        {
            string cardFace = "4";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("5"))
        {
            string cardFace = "5";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("6"))
        {
            string cardFace = "6";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("7"))
        {
            string cardFace = "7";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("8"))
        {
            string cardFace = "8";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("9"))
        {
            string cardFace = "9";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("10"))
        {
            string cardFace = "10";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("J"))
        {
            string cardFace = "J";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("Q"))
        {
            string cardFace = "Q";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("K"))
        {
            string cardFace = "K";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
    }
    void checkRunsfor9()
    {
        string suit = cardsInHand.transform.GetChild(3).GetComponent<Image>().sprite.name;

        if (suit.Contains("Clover"))
        {
            string cardSuit = "Clover";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                checkRunOrder9();
                            }
                        }
                    }
                }
            }

        }
        if (suit.Contains("Diamonds"))
        {
            string cardSuit = "Diamonds";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                checkRunOrder9();
                            }
                        }
                    }
                }
            }
        }
        if (suit.Contains("Hearts"))
        {
            string cardSuit = "Hearts";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                checkRunOrder9();
                            }
                        }
                    }
                }
            }
        }
        if (suit.Contains("Spade"))
        {
            string cardSuit = "Spade";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        if (cardsInHand.transform.GetChild(i + 3).GetComponent<Image>().sprite.name.Contains(cardSuit))
                        {
                            if (cardsInHand.transform.GetChild(i + 4).GetComponent<Image>().sprite.name.Contains(cardSuit))
                            {
                                checkRunOrder9();
                            }
                        }
                    }
                }
            }
        }
    }
    void checkRunOrder9()
    {
        string suitNo = cardsInHand.transform.GetChild(3).GetComponent<Image>().sprite.name;
        int index = 4;

        if (suitNo.Contains("A"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("2"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("3"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("4"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("5"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("6"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("2"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("3"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("4"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("5"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("6"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("7"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("3"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("4"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("5"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("6"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("7"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("8"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("4"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("5"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("6"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("7"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("8"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("9"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("5"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("6"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("7"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("8"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("9"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("10"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("6"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("7"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("8"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("9"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("10"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("J"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("7"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("8"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("9"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("10"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("J"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("Q"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
        if (suitNo.Contains("8"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("9"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("10"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("J"))
                    {
                        if (cardsInHand.transform.GetChild(index + 3).GetComponent<Image>().sprite.name.Contains("Q"))
                        {
                            if (cardsInHand.transform.GetChild(index + 4).GetComponent<Image>().sprite.name.Contains("K"))
                            {
                                Runs = true;
                            }
                        }
                    }
                }
            }
        }
    }
    #endregion

    #region 7Cards
    void checkSetsfor7()
    {
        string cardName = cardsInHand.transform.GetChild(0).GetComponent<Image>().sprite.name;

        if (cardName.Contains("A"))
        {
            string cardFace = "A";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("2"))
        {
            string cardFace = "2";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("3"))
        {
            string cardFace = "3";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("4"))
        {
            string cardFace = "4";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("5"))
        {
            string cardFace = "5";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("6"))
        {
            string cardFace = "6";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("7"))
        {
            string cardFace = "7";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("8"))
        {
            string cardFace = "8";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("9"))
        {
            string cardFace = "9";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("10"))
        {
            string cardFace = "10";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("J"))
        {
            string cardFace = "J";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("Q"))
        {
            string cardFace = "Q";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
        if (cardName.Contains("K"))
        {
            string cardFace = "K";

            int i = 1;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardFace))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardFace))
                {
                    Sets = true;
                }
            }
        }
    }
    void checkRunsfor7()
    {
        string suit = cardsInHand.transform.GetChild(3).GetComponent<Image>().sprite.name;

        if (suit.Contains("Clover"))
        {
            string cardSuit = "Clover";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        checkRunOrder7();
                    }
                }
            }

        }
        if (suit.Contains("Diamonds"))
        {
            string cardSuit = "Diamonds";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        checkRunOrder7();
                    }
                }
            }
        }
        if (suit.Contains("Hearts"))
        {
            string cardSuit = "Hearts";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        checkRunOrder7();
                    }
                }
            }
        }
        if (suit.Contains("Spade"))
        {
            string cardSuit = "Spade";

            int i = 4;

            if (cardsInHand.transform.GetChild(i).GetComponent<Image>().sprite.name.Contains(cardSuit))
            {
                if (cardsInHand.transform.GetChild(i + 1).GetComponent<Image>().sprite.name.Contains(cardSuit))
                {
                    if (cardsInHand.transform.GetChild(i + 2).GetComponent<Image>().sprite.name.Contains(cardSuit))
                    {
                        checkRunOrder7();
                    }
                }
            }
        }
    }
    void checkRunOrder7()
    {
        string suitNo = cardsInHand.transform.GetChild(3).GetComponent<Image>().sprite.name;
        int index = 4;

        if (suitNo.Contains("A"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("2"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("3"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("4"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("2"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("3"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("4"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("5"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("3"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("4"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("5"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("6"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("4"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("5"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("6"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("7"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("5"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("6"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("7"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("8"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("6"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("7"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("8"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("9"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("7"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("8"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("9"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("10"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("8"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("9"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("10"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("J"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("9"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("10"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("J"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("Q"))
                    {
                        Runs = true;
                    }
                }
            }
        }
        if (suitNo.Contains("10"))
        {
            if (cardsInHand.transform.GetChild(index).GetComponent<Image>().sprite.name.Contains("J"))
            {
                if (cardsInHand.transform.GetChild(index + 1).GetComponent<Image>().sprite.name.Contains("Q"))
                {
                    if (cardsInHand.transform.GetChild(index + 2).GetComponent<Image>().sprite.name.Contains("K"))
                    {
                        Runs = true;
                    }
                }
            }
        }
    }
    #endregion
    void checkRummy()
    {
        if(noCards == 13)
        {
            checkSetsfor13();
            checkRunsfor13();
        }

        if (noCards == 9)
        {
            checkSetsfor9();
            checkRunsfor9();
        }

        if (noCards == 7)
        {
            checkSetsfor7();
            checkRunsfor7();
        }
    }
}
