using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private AudioSource Sound;
    private float startPosX;
    private float startPosY;
    private Vector2 clickPosition;
    private float deltaX, deltaY;
    private BoxCollider2D keyCollider;
    private bool moveAllowed;
    [SerializeField] private GameObject door,key;
    private BoxCollider2D doorcollider;
    

    //[SerializeField] private GameObject doorlock, door;
    
    
    // Start is called before the first frame update
    void Start()
    {
        keyCollider = GameObject.FindWithTag("key").GetComponent<BoxCollider2D>();
        keyCollider.enabled = true;
        
        doorcollider = GameObject.FindWithTag("Door").GetComponent<BoxCollider2D>();
        doorcollider.enabled = true;
        moveAllowed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAllowed)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos= Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
            
            if (keyCollider == Physics2D.OverlapPoint(mousePos))
            {
                deltaX = mousePos.x - transform.position.x;
                deltaY = mousePos.y - transform.position.y;
                moveAllowed = true;
            }
            
            if (keyCollider == Physics2D.OverlapPoint(mousePos) && moveAllowed)
            {
                transform.position = new Vector3(mousePos.x - deltaX, mousePos.y - deltaY, 0);
            }
        }
        
        
    }

    private void OnMouseDown()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        moveAllowed = true;
        

    }

    private void OnMouseUp()
    {
        moveAllowed = false;

        if (keyCollider.bounds.Intersects(doorcollider.bounds))
        {
            Sound.Play();
            SceneManager.LoadScene("Scene12");
        }
    }
}
