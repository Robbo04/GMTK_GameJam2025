 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager instance;

    [SerializeField] private AudioSource soundFXObject;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }


    }
    public void PlaySoundFXCLip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        //spawn game obj
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        //assign clip
        audioSource.clip = audioClip;

        //assign volume
        audioSource.volume = volume;

        //play sound
        audioSource.Play();

        //get length of sound clip
        float clipLength = audioSource.clip.length;

        //destroy when finished playing  
        Destroy(audioSource.gameObject, clipLength);
    }
} 
