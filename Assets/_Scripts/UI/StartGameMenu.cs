using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] gameModeButtons;
    [SerializeField] private PlayerController playerController;
    public void StartGame()
    {
        
        for(int count = 0; count < gameModeButtons.Length; count ++)
        {
            gameModeButtons[count].SetActive(false);
        }
        playerController.IsFinish = false;
    }
    public void ResultMenu()
    {
        gameModeButtons[2].SetActive(true);
    }
}
