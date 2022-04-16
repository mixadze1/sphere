using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultMenu : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject[] resultMenu;
    [SerializeField] private GameObject[] startGameMenu;
    
    public void Restart()
    {
        for (int count = 0; count < resultMenu.Length; count++)
        { 
            resultMenu[count].SetActive(false); 
        }

        for (int count = 0; count < resultMenu.Length; count++)
        {
            startGameMenu[count].SetActive(true);
        }
        playerController.RestartGame();
    }
}
