using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnersGateScript : MonoBehaviour
{
    [SerializeField] AudioClip CoinCollect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Level Complete");
        //SoundFXManager.instance.PlaySoundFXCLip(CoinCollect, transform, 1f);
        Destroy(this.gameObject);
    }
}

