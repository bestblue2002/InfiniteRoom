using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPopUp : MonoBehaviour
{
    //[SerializeField] private AudioSource Sound;
    public GameObject popup;
    public void Start()
    {
        popup.SetActive(false);
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
            //Sound.Play();
            popup.SetActive(true);
            
        }
    }
}
