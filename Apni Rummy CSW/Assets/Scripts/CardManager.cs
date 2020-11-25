using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;

    [SerializeField]
    private List<Sprite> cardSprite = null;

    List<int> cardList = new List<int>();

    public Text displayText;

    [SerializeField] private GameObject cardInHand = null;
    [SerializeField] private GameObject cardPrefab = null;
    [SerializeField] private GameObject dummyCardPrefab = null;
    [SerializeField] private GameObject CardHolder = null;
    [SerializeField] private GameObject DeckPileHolder = null;
    [SerializeField] private GameObject DiscardedCard = null;

    private int cardPickNo = 1;
    private int noCards;
    private int k, childCount, randomCardNo, randomCardPick, indexNo;

    private GameObject cardSelectedForDrop;
    private GameObject card;
    private CardMechanics selectedCard, prevCard, nxtCard;
    private GameObject dummyCard;
    public GameObject dropCardBt;
    public CardMechanics SelectedCard { get => selectedCard; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        for (int cardIndex = 0; cardIndex < 52; cardIndex++)
        {
            cardList.Add(cardIndex);
        }
        cardInHand.SetActive(false);
        Invoke("SpawnFirstDiscardedCard", 7);

        Debug.Log(PlayerPrefs.GetInt("Players"));
        int noPlayers = PlayerPrefs.GetInt("Players");

        if(noPlayers == 2)
        {
            noCards = 13;
            for (int i = 0; i < 13; i++)
            {
                k = i;
                SpawnCard();
                Invoke("ShowCards", 7);
            }
        }

        if (noPlayers == 3)
        {
            noCards = 9;
            for (int i = 0; i < 9; i++)
            {
                k = i;
                SpawnCard();
                Invoke("ShowCards", 7);
            }
        }

        if (noPlayers == 4)
        {
            noCards = 7;
            for (int i = 0; i < 7; i++)
            {
                k = i;
                SpawnCard();
                Invoke("ShowCards", 7);
            }
        }    
    }
    private void Update()
    {
        int DiscardedCardsNo = DiscardedCard.transform.childCount;

        for(int i= 0; i < DiscardedCardsNo; i++)
        {
            Destroy(DiscardedCard.transform.GetChild(i).GetComponent<CardMechanics>());
        }
    }

    void ShowCards()
    {
        cardInHand.SetActive(true);
    }

    public void SetSelectedCard(CardMechanics card)
    {
        int selectedCardIndex = card.transform.GetSiblingIndex();
        selectedCard = card;
        selectedCard.childIndex = selectedCardIndex;

        GetDummyCard().SetActive(true);
        GetDummyCard().transform.SetSiblingIndex(selectedCardIndex);

        selectedCard.transform.SetParent(CardHolder.transform);

        childCount = cardInHand.transform.childCount;

        if (selectedCardIndex + 1 < childCount)
        {
            nxtCard = cardInHand.transform.GetChild(selectedCardIndex + 1).GetComponent<CardMechanics>();
        }

        if (selectedCardIndex - 1 >= 0)
        {
            prevCard = cardInHand.transform.GetChild(selectedCardIndex - 1).GetComponent<CardMechanics>();
        }
    }

    public void DragCard(Vector2 position)
    {
        if (selectedCard != null)
        {
            if (cardInHand.transform.childCount == noCards + 1)
            {
                dropCardBt.SetActive(true);
            }
            else
            {
                dropCardBt.SetActive(false);
            }
            selectedCard.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.8f);
            selectedCard.transform.position = position;
            
            CheckPreviousCard();
            CheckNextCard();          
        }
    }

    public void ReleaseCard()
    {
        if (selectedCard != null)
        {
            GetDummyCard().SetActive(false);

            selectedCard.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
            selectedCard.transform.SetParent(cardInHand.transform);

            if (Mathf.Abs(selectedCard.transform.position.y - dummyCard.transform.position.y) > 80)
            {
                GetDummyCard().transform.SetParent(CardHolder.transform);
                selectedCard.transform.SetSiblingIndex(selectedCard.childIndex);
            }
            else
            {
                selectedCard.transform.SetSiblingIndex(GetDummyCard().transform.GetSiblingIndex());
                GetDummyCard().transform.SetParent(CardHolder.transform);
            }

            if (dropCardBt.activeSelf)
            {
                float dropBt_x = dropCardBt.transform.position.x;
                float dropBt_y = dropCardBt.transform.position.y;

                if (Mathf.Round(selectedCard.transform.position.x) > dropBt_x - 25 && Mathf.Abs(selectedCard.transform.position.x) < dropBt_x + 20)
                {
                    if (Mathf.Abs(selectedCard.transform.position.y) > dropBt_y - 20 && Mathf.Abs(selectedCard.transform.position.y) < dropBt_y + 30)
                    {
                        if (cardInHand.transform.childCount == noCards + 1)
                        {
                            selectedCard.transform.SetParent(DiscardedCard.transform);
                        }
                    }
                }
            }           

            dropCardBt.SetActive(false);
            selectedCard = null;
        }
    }

    void CheckPreviousCard()
    {
        if (prevCard != null)
        {
            if (selectedCard.transform.position.x < prevCard.transform.position.x)
            {
                int index = prevCard.transform.GetSiblingIndex();
                prevCard.transform.SetSiblingIndex(dummyCard.transform.GetSiblingIndex());
                dummyCard.transform.SetSiblingIndex(index);

                nxtCard = prevCard;
                if (index - 1 >= 0)
                {
                    prevCard = cardInHand.transform.GetChild(index - 1).GetComponent<CardMechanics>();
                }
                else
                {
                    prevCard = null;
                }
            }
        }
    }

    void CheckNextCard()
    {
        if(nxtCard != null)
        {
            if(selectedCard.transform.position.x > nxtCard.transform.position.x)
            {
                int index = nxtCard.transform.GetSiblingIndex();
                nxtCard.transform.SetSiblingIndex(dummyCard.transform.GetSiblingIndex());
                dummyCard.transform.SetSiblingIndex(index);

                prevCard = nxtCard;
                if(index + 1 < childCount)
                {
                    nxtCard = cardInHand.transform.GetChild(index + 1).GetComponent<CardMechanics>();
                }
                else
                {
                    nxtCard = null;
                }
            }
        }
    }

    void SpawnCard()
    {
        randomCardNo = Random.Range(0, cardList.Count - 1);    
        indexNo = cardList[randomCardNo];    
        cardList.RemoveAt(randomCardNo);

        card = Instantiate(cardPrefab);
        card.name = "Card " + k;
        card.transform.SetParent(cardInHand.transform);
        card.GetComponent<CardMechanics>().SetImage(cardSprite[indexNo]);
    }

    void SpawnFirstDiscardedCard()
    {
        randomCardNo = Random.Range(0, cardList.Count - 1);
        indexNo = cardList[randomCardNo];
        cardList.RemoveAt(randomCardNo);

        card = Instantiate(cardPrefab);
        card.name = "FirstCard";
        card.transform.SetParent(DiscardedCard.transform);
        card.GetComponent<CardMechanics>().SetImage(cardSprite[indexNo]);
    }
    public void PickFromDeckCards()
    {
        if(cardList.Count != 0)
        {
            if(cardInHand.transform.childCount == noCards)
            {
                randomCardPick = Random.Range(0, cardList.Count - 1);
                indexNo = cardList[randomCardPick];
                cardList.RemoveAt(randomCardPick);

                card = Instantiate(cardPrefab);
                card.name = "Deck Card " + cardPickNo;
                card.transform.SetParent(cardInHand.transform);
                card.GetComponent<CardMechanics>().SetImage(cardSprite[indexNo]);

                cardPickNo++;
            }
            else
            {
               StartCoroutine(checkCards());
            }
        }
        else
        {
            DeckPileHolder.SetActive(false);
        }
    }

    public void PickFromDiscardedCards()
    {
        if (cardInHand.transform.childCount == noCards)
        {
            int DiscardedCardsNo = DiscardedCard.transform.childCount;

            DiscardedCard.transform.GetChild(DiscardedCardsNo - 1).gameObject.AddComponent<CardMechanics>();
            DiscardedCard.transform.GetChild(DiscardedCardsNo - 1).SetParent(cardInHand.transform);
        }
        else
        {
            StartCoroutine(checkCards());
        }
    }

    IEnumerator checkCards()
    {
        displayText.text = "Drop a Card";
        yield return new WaitForSeconds(4f);
        displayText.text = "";
    }

    GameObject GetDummyCard()
    {
        if(dummyCard != null)
        {
            if(dummyCard.transform.parent != cardInHand.transform)
            {
                dummyCard.transform.SetParent(cardInHand.transform);
            }           
            return dummyCard;
        }
        else
        {
            dummyCard = Instantiate(dummyCardPrefab);
            dummyCard.name = "DummyCard";
            dummyCard.transform.SetParent(cardInHand.transform);
        }

        return dummyCard; 
    }  
}
