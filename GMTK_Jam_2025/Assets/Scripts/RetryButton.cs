using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
