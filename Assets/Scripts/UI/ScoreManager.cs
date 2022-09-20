using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public UpdateScore updater;
    public bool gameEnded;
    public Text gameHasEnded;
    //public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        gameHasEnded = GameObject.Find("gameHasEnded").GetComponent<Text>();
        gameHasEnded.enabled = false;
        playerScore = 0;
    }
    private void Update()
    {
        if (playerScore > 200) {
            gameEnded = true;
            gameHasEnded.enabled = true;
            //TimerOn = false;
            gameHasEnded.text = "You Won!!";
            Time.timeScale = 0;

        }
    }
    // Update is called once per frame
    public void addScore(int scoreObtained)
    {
        playerScore += scoreObtained;
        updater.UpdateScoreText(playerScore);
        //UpdateScore.Update
    }
}
