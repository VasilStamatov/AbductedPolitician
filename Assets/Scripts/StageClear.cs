using UnityEngine;
using System.Collections;

public class StageClear : MonoBehaviour 
{
    void OnTriggerEnter2D()
    {
        if (Application.loadedLevel != 5)
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
        else
        {
            Application.Quit();
        }
    }
}
