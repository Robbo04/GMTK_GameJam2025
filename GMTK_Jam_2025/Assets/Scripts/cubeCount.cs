using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeCount : MonoBehaviour
{

    [SerializeField] public GameObject[] uiImages;


    private int counter = 0;
    // Start is called before the first frame update
    

    public void RemoveNext()
    { 
        uiImages[counter].SetActive(false);
        counter++;
        print(counter);
    }

    public int GetUpcoming()
    {
        

        if (uiImages[counter].gameObject.tag == "Common")
        {
            print(0);
            return 0;
        }
        else if (uiImages[counter].gameObject.tag == "Bouncy")
        {
            print(1);
            return 1;
        }
        else if (uiImages[counter].gameObject.tag == "Heavy")
        {
            print(2);
            return 2;
        }
       

        return -1;
    }
}
