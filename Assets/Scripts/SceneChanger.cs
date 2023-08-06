using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public Animator animator;
    private int SceneIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
