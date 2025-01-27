﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralLevelUI : MonoBehaviour
{
    
    [SerializeField]
    GameObject victoryPage;
    [SerializeField]
    GameObject restartPage;
    [SerializeField]
    GameObject settingsPage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OpenSettingsPage(){
        Time.timeScale = 0;
        settingsPage.SetActive(true);
        restartPage.SetActive(false);

    }
    public void OpenRestartPage(){
        Time.timeScale = 0;
        settingsPage.SetActive(false);
        restartPage.SetActive(true);

    }
    public void OpenVictoryPage(){
        Time.timeScale = 0;
        settingsPage.SetActive(false);
        restartPage.SetActive(false);
        victoryPage.SetActive(true);

    }
    public void RestartTheGame()
    {
        Time.timeScale = 1;
        settingsPage.SetActive(false);
        restartPage.SetActive(false);
        ResetCurrentScene();

    }
    public void OpenNextLevel()
    {
        Time.timeScale = 1;
        settingsPage.SetActive(false);
        restartPage.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    private static void ResetCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CloseSettingsPage(){
        Time.timeScale = 1;
        settingsPage.SetActive(false);

    }
    
    public void OpenMainMenuPage(){
        Time.timeScale = 1;
        settingsPage.SetActive(false);
        SceneManager.LoadScene(0);

    }
}
