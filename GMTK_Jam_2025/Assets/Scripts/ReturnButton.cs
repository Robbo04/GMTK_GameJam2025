using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public string buttonType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        if (buttonType == "Main Menu")
        {
            SceneManager.LoadScene(buttonType.ToString());
        }
    }
}
