using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //variables
    public TMP_Text buttonText;
    public string buttonType;
    
    public void Start()
    {
        buttonType = buttonText.text;
    }

    // Update is called once per frame
    public void OpenScene()
    {
        print (buttonType);
        if (buttonType == "Play")
        {
            SceneManager.LoadScene(buttonType.ToString());
        }
        else if (buttonType == "Settings")
        {
            SceneManager.LoadScene(buttonType.ToString());
        }
        else if (buttonType == "Exit")
        {
            print("Quit NOW");
            Application.Quit();
        }
    }
}
