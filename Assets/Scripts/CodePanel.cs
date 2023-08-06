using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField] private Text codeText;
    private string codeTextValue = "";
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "1968")
        {
            Debug.Log("You win");
            SceneManager.LoadScene("Scene11");
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddNumber(string digit)
    {
        codeTextValue += digit;
    }
    
}
