using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audio : MonoBehaviour
{
    public static audio Instance;
    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing on the Audio game object.");
        }
    }

    public void PlaySoundEffect()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}