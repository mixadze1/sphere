using UnityEngine;

public class StartGameMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] gameModeButtons;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Score score;

    public void StartGame()
    {        
        for(int count = 0; count < gameModeButtons.Length; count ++)
        {
            gameModeButtons[count].SetActive(false);
        }
        playerController.IsCanMove = true;
        score.ScoreActivate.Invoke();
    }

    public void ResultMenu()
    {
        gameModeButtons[2].SetActive(true);
    }
}
