using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceScoreText;
    [SerializeField] private TMPro.TextMeshProUGUI bestScoreText;
    [SerializeField] private GameObject newBestScoreLabel;
    [SerializeField] private GameObject bestScore;
    private int bestscore;
    private int score;
}
