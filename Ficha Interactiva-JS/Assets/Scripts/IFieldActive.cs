using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IFieldActive : MonoBehaviour
{
    public GameObject ifActivate;
    // Start is called before the first frame update
    void Start()
    {
        ifActivate.SetActive(false);
    }

    void ActiveIF()
    {
        ifActivate.SetActive(true);
    }
}
