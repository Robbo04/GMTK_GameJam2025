using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinMenuButton : MonoBehaviour
{
    public string buttonType;
    public Scene currentScene;
    public int level;
    private TMP_Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenWinScene()
    {
        if (buttonType == "Main Menu")
        {
            SceneManager.LoadScene(buttonType);
        }
        else if (buttonType == "Replay")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (buttonType == "Next")
        {
            level = level + 1;
            SceneManager.LoadScene("Level" + level.ToString());
        }
    }
}
