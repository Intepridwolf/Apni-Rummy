using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiSwitch : MonoBehaviour
{

    public GameObject homeUI;
    public GameObject categoryUI;
    public GameObject privateUI;
    public GameObject earncashUI;
    public GameObject scratchUI;
    public GameObject storeUI;
    public GameObject profileUI;
 
    void Start()
    {
        PlayerPrefs.DeleteAll();
        Home();
    }
    public void Home()
    {
        homeUI.SetActive(true);
        categoryUI.SetActive(false);
        privateUI.SetActive(false);
        earncashUI.SetActive(false);
        scratchUI.SetActive(false);
        storeUI.SetActive(false);
        profileUI.SetActive(false);
    }
    public void Category()
    {
        homeUI.SetActive(false);
        categoryUI.SetActive(true);
        privateUI.SetActive(false);
        earncashUI.SetActive(false);
        scratchUI.SetActive(false);
        storeUI.SetActive(false);
        profileUI.SetActive(false);
    }
    public void Private()
    {
        homeUI.SetActive(false);
        categoryUI.SetActive(false);
        privateUI.SetActive(true);
        earncashUI.SetActive(false);
        scratchUI.SetActive(false);
        storeUI.SetActive(false);
        profileUI.SetActive(false);
    }
    public void Earn()
    {
        homeUI.SetActive(false);
        categoryUI.SetActive(false);
        privateUI.SetActive(false);
        earncashUI.SetActive(true);
        scratchUI.SetActive(false);
        storeUI.SetActive(false);
        profileUI.SetActive(false);
    }
    public void Scratch()
    {
        homeUI.SetActive(false);
        categoryUI.SetActive(false);
        privateUI.SetActive(false);
        earncashUI.SetActive(false);
        scratchUI.SetActive(true);
        storeUI.SetActive(false);
        profileUI.SetActive(false);
    }
    public void Store()
    {
        homeUI.SetActive(false);
        categoryUI.SetActive(false);
        privateUI.SetActive(false);
        earncashUI.SetActive(false);
        scratchUI.SetActive(false);
        storeUI.SetActive(true);
        profileUI.SetActive(false);
    }
    public void Profile()
    {
        homeUI.SetActive(false);
        categoryUI.SetActive(false);
        privateUI.SetActive(false);
        earncashUI.SetActive(false);
        scratchUI.SetActive(false);
        storeUI.SetActive(false);
        profileUI.SetActive(true);
    }

    public void twoPlayerBt()
    {
        PlayerPrefs.SetInt("Players", 2);
    }
    public void threePlayerBt()
    {
        PlayerPrefs.SetInt("Players", 3);
    }
    public void fourPlayerBt()
    {
        PlayerPrefs.SetInt("Players", 4);
    }

    public void clearPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
