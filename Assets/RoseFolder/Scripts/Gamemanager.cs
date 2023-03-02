using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    //Variables
    //HUD
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    //General
    public bool isGameActive;
    private float spawnRate = 5;
    public GameObject titleScreen;


    // Start is called before the first frame update
    void Start()
    {

        isGameActive = true;
    }
    /*
    //Starts the Game
    public void StartGame(int difficulty)
    {
        Debug.Log("GAME START");
        titleScreen.gameObject.SetActive(false);
        spawnRate /= difficulty;
        score = 0;
        UpdateScore(0);
        isGameActive = true;


    }


    public void GameOver()
    {
        Debug.Log("GAME OVER");
        gameOverText.gameObject.SetActive(true);
        Debug.Log("GAME OVER SCREEN APPEARS");
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        Debug.Log("RESTART BUTTON APPEARS");
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {

    }
    */
}
