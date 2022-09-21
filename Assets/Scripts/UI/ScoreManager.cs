using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;

    public void UpdateScore(int scoreObtained)
    {
        playerScore += scoreObtained;
    }
}
