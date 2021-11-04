using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_trigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioFile;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            audioFile.Play();
    }

}
