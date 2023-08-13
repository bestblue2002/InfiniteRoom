using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public Animator animator;
    private int SceneIndex;

    

    public void NextButtonScene()
    {
        FadetoScenes(SceneManager.GetActiveScene().buildIndex + 1);
        
        
    }

    public void FadetoScenes(int sceneindex)
    {
        SceneIndex = sceneindex;
        animator.SetTrigger("fadeout");
        
    }

    public void FadeComplete()
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
