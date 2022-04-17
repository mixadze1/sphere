using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private TextMeshProUGUI distanceScore;
    [SerializeField] private TextMeshProUGUI timeScore;
    [SerializeField] private TextMeshProUGUI timeBestScore;
    [SerializeField] private TextMeshProUGUI bestScore;
    [SerializeField] private GameObject player;
    private Action scoreActivate;
    private float bestPosition;
    private int time = 0;
    public Action ScoreActivate { get => scoreActivate; set => scoreActivate = value; }
    private void Start()
    {
        scoreActivate = Coroutine;

        PlayerPrefs.SetInt("Score", ((int)bestPosition));
        PlayerPrefs.SetInt("Time", time);
        timeScore.text = PlayerPrefs.GetInt("Time").ToString();
        timeBestScore.text = PlayerPrefs.GetInt("BestTime").ToString();
        distanceScore.text = PlayerPrefs.GetInt("Score").ToString();
        bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    private void Coroutine()
    {
        StartCoroutine(ScoreText());
        StartCoroutine(TimeText());
    }

    private IEnumerator ScoreText()
    {
        if (playerController.IsCanMove == true)
        {
            while (playerController.IsCanMove == true)
            {
                yield return new WaitForSeconds(0.1f);
                if (player.transform.position.z > bestPosition)
                { 
                    bestPosition = player.transform.position.z; 
                }
                PlayerPrefs.SetInt("Score", ((int)bestPosition));
                distanceScore.text = PlayerPrefs.GetInt("Score").ToString();
            }
            if (PlayerPrefs.GetInt("BestScore") < PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("BestScore", ((int)bestPosition));
            }          
        }
        bestPosition = 0;
        PlayerPrefs.SetInt("Score", ((int)bestPosition));
        distanceScore.text = PlayerPrefs.GetInt("Score").ToString();
        BestScore();
    }

    private IEnumerator TimeText()
    {    
        if (playerController.IsCanMove == true)
        {
            while (playerController.IsCanMove == true)
            {
                time++;
                yield return new WaitForSeconds(1f);               
                PlayerPrefs.SetInt("Time", time);
                timeScore.text = PlayerPrefs.GetInt("Time").ToString();    
            }

        }
        if (PlayerPrefs.GetInt("BestTime") == 0)
        {
            PlayerPrefs.SetInt("BestTime", time);
        }
        else if (PlayerPrefs.GetInt("BestTime") > PlayerPrefs.GetInt("Time"))
        {
            PlayerPrefs.SetInt("BestTime", time-1);
        }
        time = 0;
        PlayerPrefs.SetInt("Time", time);
        timeScore.text = PlayerPrefs.GetInt("Time").ToString();
        BestTime();
    }

    private void BestScore()
    {
        bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    private void BestTime()
            {
        timeBestScore.text = PlayerPrefs.GetInt("BestTime").ToString();
            }
}
