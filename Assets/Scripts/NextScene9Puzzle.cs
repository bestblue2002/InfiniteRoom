using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene9Puzzle : MonoBehaviour
{
    [SerializeField] private AudioSource Puzzle;
    //public GameObject 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Puzzle.Play();
            SceneManager.LoadScene("Scene9");
        }
    }
}
