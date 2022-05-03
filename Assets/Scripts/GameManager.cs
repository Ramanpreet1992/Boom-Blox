using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int ballsRemaining = 4;
    public int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI bRText;
    [SerializeField] TextMeshProUGUI gameOverText;
    public GameObject go;

    private void OnEnable()
    {
        // Set singleton reference
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartScene();
        }
        GameOver();
    }

    public void UpdateScore(int newScore)
    {
        score = newScore;
        scoreText.text = $"Score: {score}";
    }

    public void UpdateBallsRemaining(int br)
    {
        ballsRemaining = br;
        bRText.text = $"Balls Remaining: {ballsRemaining}";
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {

        if (go.transform.childCount == 0  )
        {
            gameOverText.text = $"You won!!";
        }
        else if (GameManager.instance.ballsRemaining == 0 && go.transform.childCount!=0)
        {
            gameOverText.text = $"Game Over";
        }
    }
}
