using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroMenuController : MonoBehaviour
{


    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void ResetScore()
    {
        CorrectScore.totalScore = 0;
        Debug.Log("De vuelta a cero");
    }

    public void Resetmedal()
    {
        ScoreController.control.medalScore = 0;
        Debug.Log("Medalla de vuelta a cero");
    }

    public void AnswerCheckButton()
    {
        CorrectScore.totalScore++;
        Debug.Log(CorrectScore.totalScore + "= Correct Answer");
    }

    public void StartAgain()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }
}
