using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IFAnsCheck : MonoBehaviour
{

    //public Button Button;
    public InputField iField;
    public string Ctext;
    
    public void AnswerCheckIField()
    {
        string AnswerCorr = iField.text;
        if (AnswerCorr == Ctext)
        {
            CorrectScore.totalScore++;
            //Debug.Log(CorrectScore.scoreCorrector.totalScore);
           
            Debug.Log(CorrectScore.totalScore + "= Correct Answer");
        }
        else
        {
            //Debug.Log(CorrectScore.scoreCorrector.totalScore);
            Debug.Log("Incorrect . Sin cambios");
        }
    }
}
