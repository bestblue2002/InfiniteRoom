using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextMenu : MonoBehaviour
{
    public void NextButtonScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
