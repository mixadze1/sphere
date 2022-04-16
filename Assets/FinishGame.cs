using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    [SerializeField] private GameObject winMenu;
    [SerializeField] private GameObject loseMenu;

    public void StartFinish(bool checkMenu)
    {
        if (checkMenu == true)
        {
            winMenu.SetActive(true);
            loseMenu.SetActive(false);
        }
        else
        {
            winMenu.SetActive(false);
            loseMenu.SetActive(true);
        }
    }
}
