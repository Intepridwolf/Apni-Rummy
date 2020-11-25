using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public Text displayText;
    public Text cardsInHandText;
    public GameObject cardsInHand;

    public GameObject WonUI;
    public GameObject BlurImage;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player3_mid;
    public GameObject Player4;

    public void Start()
    {
        print("Start");
        BlurImage.SetActive(false);
        WonUI.SetActive(false);

        NoPlayers();
        StartCoroutine(LoadGame());
    }
    void Update()
    {
        StartCoroutine(CountHandCards());        
    }
    IEnumerator LoadGame()
    {
        for(int i=5;i>0;i--)
        {
            yield return new WaitForSeconds(1f);
            displayText.text = "New Game Begins In " + i+ " Seconds";
        }
        displayText.text = "Dealing Cards";
        yield return new WaitForSeconds(2f);
        displayText.text = "";
        yield return new WaitForSeconds(2f);
        displayText.text = "Pick a Card from Deck or Discarded Pile";
        yield return new WaitForSeconds(4f);
        displayText.text = "Drop a Card from your Hand";
        yield return new WaitForSeconds(4f);
        displayText.text = "Make both a Run and a Set to win The Game";
        yield return new WaitForSeconds(4f);
        displayText.text = "";
    }
    IEnumerator CountHandCards()
    {
        yield return new WaitForSeconds(7f);
        cardsInHandText.text = "Cards In Hand : " + cardsInHand.transform.childCount;
    }
    public void newGame()
    {
        // Start();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NoPlayers()
    {
        if(PlayerPrefs.GetInt("Players") == 2)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(false);
            Player3_mid.SetActive(false);
            Player4.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Players") == 3)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(false);
            Player3_mid.SetActive(true);
            Player4.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Players") == 4)
        {
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player3.SetActive(true);
            Player4.SetActive(true);
            Player3_mid.SetActive(false);
        }
    }
    public void clearPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
