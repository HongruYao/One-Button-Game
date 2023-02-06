using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip diedSound, jumpSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        diedSound = Resources.Load<AudioClip>("Died");
        jumpSound = Resources.Load<AudioClip>("Jump");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Died":
                audioSrc.PlayOneShot(diedSound); break;
            case "Jump":
                audioSrc.PlayOneShot(jumpSound); break;
        }
    }
}
