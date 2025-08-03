using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnersGateScript : MonoBehaviour
{
    [SerializeField] AudioClip CoinCollect;
    [SerializeField] public GameObject retryButton;
    [SerializeField] public GameObject winScreen;


    void Start()
    {
        winScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Level Complete");
        retryButton.SetActive(false);
        winScreen.SetActive(true);
        //SoundFXManager.instance.PlaySoundFXCLip(CoinCollect, transform, 1f);
        Destroy(this.gameObject);
    }
}

