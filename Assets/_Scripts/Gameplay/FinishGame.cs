using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    [SerializeField] private GameObject winMenu;
    [SerializeField] private GameObject loseMenu;
    [SerializeField] private GameObject ResultMenu;

    public void StartFinish(bool checkMenu)
    {
        ResultMenu.SetActive(true);

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
