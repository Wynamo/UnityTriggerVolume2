using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffect : MonoBehaviour
{
    public AudioSource SFX;
    private void OnTriggerEnter(Collider other)
    {
        SFX.Play();
    }

    

}
