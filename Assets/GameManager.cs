using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int lives;
    public int score;
    public Text livesTest;
    public Text scoreText;
    public bool gameOver;
    public GameObject gameOverPanel;
    public int numberOfBricks;


    // Start is called before the first frame update
    void Start()
    {


        scoreText.text = "Score: " + score;
        livesTest.text = "Lives: " + lives;
        numberOfBricks = GameObject.FindGameObjectsWithTag("brick").Length;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }

        livesTest.text = "Lives: " + lives;
    }

    public void UpdateScore(int points)
    {
        score += points;

        scoreText.text = "score: " + score;
    }

    public void UpdateNumberOfBricks()
    {
        numberOfBricks--;
        if (numberOfBricks <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}