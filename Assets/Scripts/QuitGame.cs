using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("See you later!");
    }
}
