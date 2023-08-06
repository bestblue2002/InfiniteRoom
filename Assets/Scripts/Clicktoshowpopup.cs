using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicktoshowpopup : MonoBehaviour
{
    //[SerializeField] private AudioSource Book;
    public GameObject popup;
    //public GameObject button;
    public void Start()
    {
        popup.SetActive(false);
       // button.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            popup.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Book.Play();
            popup.SetActive(true);

            if (popup.activeInHierarchy == true)
            {
                //button.SetActive(true);
            }
        }
    }
}
