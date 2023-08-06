using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public int pointsToWin;
    public static int currentPoints;
    public GameObject Puzzle;

    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = Puzzle.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            //Win
            SceneManager.LoadScene("Scene8");
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
