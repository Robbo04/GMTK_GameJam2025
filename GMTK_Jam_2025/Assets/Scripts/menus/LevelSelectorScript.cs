using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class LevelSelectorScript : MonoBehaviour
{
    public int level;
    public TMP_Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "Level " + level.ToString();
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Level" + level.ToString());
    }
}
