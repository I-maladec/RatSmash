using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] TextMeshProUGUI _bestScoreText;
    string scoreName = "Score";
    int bestScore;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        bestScore = PlayerPrefs.GetInt(scoreName);
    }
    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Очки: " +score.ToString();
        _bestScoreText.text = "Найкращий результат: " + bestScore.ToString();
        if (bestScore < score)
        {
            bestScore = score;
        }
    }
    public void AddPoints(int points)
    {
        score += points;
    }
    public void SaveBest()
    {
        PlayerPrefs.SetInt(scoreName, bestScore);
    }
}