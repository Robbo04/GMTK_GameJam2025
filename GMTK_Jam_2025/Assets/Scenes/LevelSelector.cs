using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    //variables
    public int level;
    public TMP_Text levelText;
    
    //Plays at Start
    void Start()
    {
        //the text variable is set to the current level string.
        levelText.text = "Level " + level.ToString();
    }

    //when a button is pressed
    public void OpenScene() 
    {
        //loads the level set to each button
        SceneManager.LoadScene("Level" + level.ToString());
    }
}
