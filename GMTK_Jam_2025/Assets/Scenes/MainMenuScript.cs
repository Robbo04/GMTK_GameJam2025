using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //variables
    public int buttonType;
    public TMP_Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        buttonText.text = buttonType.ToString();
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene(buttonType.ToString());
    }
}
