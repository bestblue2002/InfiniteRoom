using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCheck : MonoBehaviour
{
    [SerializeField] private AudioSource DoorLock;
    [SerializeField] private AudioSource DoorOpen;
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
            DoorLock.Play();
            if (WinScript.currentPoints >= 4)
            {
                DoorOpen.Play();
                SceneManager.LoadScene("Scene10");
            }
        }
    }
}
