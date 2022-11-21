using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameScore();
    }

    private void gameScore()
    {
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}