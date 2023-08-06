using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextScene2 : MonoBehaviour
{
    public void NextButtonScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}
