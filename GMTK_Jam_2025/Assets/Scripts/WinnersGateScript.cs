using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnersGateScript : MonoBehaviour
{
    [SerializeField] AudioClip CoinCollect;

    public GameObject flag_lowered_image;
    public GameObject flag_raised_image;

    private void ToggleFlagRaised(bool isRaised)
    {
        flag_raised_image.GetComponent<Renderer>().enabled = isRaised;
        flag_lowered_image.GetComponent<Renderer>().enabled = !isRaised;
    }

    private void Start()
    {
        ToggleFlagRaised(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Level Complete");
        //SoundFXManager.instance.PlaySoundFXCLip(CoinCollect, transform, 1f);
        //Destroy(this.gameObject);
        ToggleFlagRaised(true);
    }
}

