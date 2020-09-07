using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScene : MonoBehaviour
{
    public Text loseText;
    public GameObject totalWinImage;
    public GameObject totalLose;
    

    // Start is called before the first frame update
    void Start()
    {
        totalWinImage.SetActive(false);
        totalLose.SetActive(false);
    }
    public void ActiveWin()
    {
        if (ScoreController.control.medalScore == 7)
        {
            totalWinImage.SetActive(true);
            Debug.Log("Obtiene copa");
        }
        else
        {
            loseText.text = "En la ficha solo estuviste a " + (7 - ScoreController.control.medalScore) + " medallas de obtener la copa de la ficha, recuerda que juntar las copas podría traerte una sorpresa.";
            totalLose.SetActive(true);
            Debug.Log("No obtiene copa: Faltaron" + (7 - ScoreController.control.medalScore));
        }
    }

    
}
