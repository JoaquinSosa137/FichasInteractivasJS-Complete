using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChange : MonoBehaviour
{
    public GameObject[] toActivate;

    void Start()
    {
        foreach (var item in toActivate)
        {
            item.SetActive(false);
        }
        
    }

    private void ActiveGameObjects()
    {
        foreach (var item in toActivate)
        {
            item.SetActive(true);

        }

    }
}
