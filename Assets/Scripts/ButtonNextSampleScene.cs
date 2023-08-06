using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextSampleScene : MonoBehaviour
{
    public void NextButtonScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
