using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenuManager : MonoBehaviour
{
    public void Change()
    {
        Screen.fullscreen = !Screen.fullscreen;
        print("changed screen mode");
    }
}
