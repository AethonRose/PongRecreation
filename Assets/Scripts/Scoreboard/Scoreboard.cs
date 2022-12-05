using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] GameObject ballRef;
    [SerializeField] TextMeshProUGUI aiScoreText;
    [SerializeField] TextMeshProUGUI playerScoreText;
    [SerializeField] GameObject playerWinsScreen;
    [SerializeField] GameObject aiWinsScreen;

    [SerializeField] int maxScore;

    int playerScore;
    int aiScore;
    

    void Start()
    {
        ResetScoreBoard();
    }

    void FixedUpdate()
    {
        CheckIfScored();
        CheckWin();
    }

    void ResetScoreBoard()
    {
        playerScore = 0;
        aiScore = 0;

        playerScoreText.SetText(playerScore.ToString());
        aiScoreText.SetText(aiScore.ToString());
    }

    void CheckIfScored()
    {
        if (ballRef.transform.position.x > 10)
        {
            AddAIPoint();
        }
        if (ballRef.transform.position.x < -10)
        {
            AddPlayerPoint();
        }
    }

    public void AddAIPoint()
    {
        aiScore++;
        aiScoreText.SetText(aiScore.ToString());
    }

    public void AddPlayerPoint()
    {
        playerScore++;
        playerScoreText.SetText(playerScore.ToString());
    }

    void CheckWin()
    {
        if (playerScore == maxScore)
        {
            playerWinsScreen.SetActive(true);
            Destroy(ballRef);
        }

        if (aiScore == maxScore)
        {
            aiWinsScreen.SetActive(true);
            Destroy(ballRef);
        }
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
