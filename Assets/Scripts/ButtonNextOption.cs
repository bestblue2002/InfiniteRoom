using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextOption : MonoBehaviour
{
    public void NextButtonScene()
    {
        SceneManager.LoadScene("Option");
    }
}
