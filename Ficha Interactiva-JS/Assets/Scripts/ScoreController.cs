using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public static ScoreController control;
    
    public int medalScore;
    //public IntroMenuController menuControl;
    

    private void Start()
    {
        if (control == null)
        {
            control = this;
            DontDestroyOnLoad(this);
        }else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    public void RaiseMedalScore(int s)
    {
        medalScore += s;
        if (medalScore > 0)
        {
            Debug.Log(medalScore);
        }
    }
    
}
