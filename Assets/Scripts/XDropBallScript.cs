using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class XDropBallScript : MonoBehaviour
    {
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI ballsLeft;
    public Button restartGame;
    public Rigidbody rb;
    public GameObject playerBall;
    public int ballAmount = 0;

    public TextMeshProUGUI finalScore;

    private void Start()
        {
        XWhichRoom.score = 0;
        UpdateBalls(0);
        gameOverText.gameObject.SetActive(false);
        restartGame.gameObject.SetActive(false);
        }

    // Update is called once per frame
    void Update()
        {
        if (Input.GetKeyDown(KeyCode.Space) && ballAmount < 10)
            {
            Instantiate(playerBall, new Vector3(10.0f, 18, 10.0f), playerBall.transform.rotation);
            ballAmount++;
            }
        else if (ballAmount > 9)
            {
            GameCompleted();
            }
        ballsLeft.text = "Balls released: " + ballAmount;
        finalScore.text = "Your score: " + XWhichRoom.score;
        }

    public void GameCompleted()
        {
        gameOverText.gameObject.SetActive(true);
        restartGame.gameObject.SetActive(true);
        }

    //private void OnCollisionEnter(Collision collision)
    //    {
    //    if (collision.gameObject.name == "Ground")
    //        {
    //        rb.AddForce(new Vector3(Random.Range(-2000, 2000), Random.Range(1, 1), Random.Range(-2000, 2000)));
    //        }
    //    }
    public void UpdateBalls(int ballsFallen)
        {
        ballAmount += ballsFallen;
        }

    public void RestartGame()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
