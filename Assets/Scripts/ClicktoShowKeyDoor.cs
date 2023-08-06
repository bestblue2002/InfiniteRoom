using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicktoShowKeyDoor : MonoBehaviour
{
    public GameObject Panel;
    
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Panel.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Panel.SetActive(true);
        }
    }
}
