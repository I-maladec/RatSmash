using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;
    [SerializeField] VolumeMaster volumeMaster;
    DateTime delayTimer;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.volume = volumeMaster.GetVolume();
        audioSource.clip = audioClip;
        delayTimer = DateTime.Now;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Enemy") || !((DateTime.Now - delayTimer) > TimeSpan.FromSeconds(1))) return;
        audioSource.Play();
        delayTimer = DateTime.Now;
    }
}
