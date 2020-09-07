using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectScore : MonoBehaviour
{
    public static CorrectScore scoreCorrector;
    public int corrScore;
    public static int totalScore = 0;
    public GameObject MedWinImage;
    
    /*public void RaiseScore(int s)
    {
        totalScore += s;
        if (totalScore > 0)
        {
            Debug.Log(totalScore + "Correct Answer");
        }
    }*/
   
    private void TotalScoreCheck()
    {
        if(totalScore > 0)
        {
            Debug.Log("Punto adquirido" + totalScore);
        }
    }

    public void AllCorrect()
    {
        if (corrScore == totalScore)
        {
            ScoreController.control.RaiseMedalScore(1);
            Debug.Log(ScoreController.control.medalScore + "; NUEVA MEDALLA");
            MedWinImage.SetActive(true);
            totalScore = 0;
            Debug.Log("totalScore reiniciado");
        }
        else
        {
            totalScore = 0;
            Debug.Log("SIN MEDALLA");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
