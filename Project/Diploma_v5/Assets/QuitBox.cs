using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitBox : MonoBehaviour
{

    public void OnSelect()
    {
        Application.Quit();
    }
}