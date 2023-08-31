using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses_artırma : MonoBehaviour
{
    public GameObject audioObject1;
    public GameObject audioObject2;
    public GameObject audioObject3;

    private AudioSource audioSource1;
    private AudioSource audioSource2;
    private AudioSource audioSource3;
    
    // Start is called before the first frame update
    void Start()
    {
        
        audioSource1 = audioObject1.GetComponent<AudioSource>();
        audioSource2 = audioObject2.GetComponent<AudioSource>();
        audioSource3 = audioObject3.GetComponent<AudioSource>();

        StartCoroutine("ses_arttır");

    // Her bir audioSource değişkeni artık kendi AudioSource bileşenine sahiptir ve bu bileşenler üzerinden işlem yapabilirsiniz.

    }

    // Update is called once per frame
    IEnumerator ses_arttır()
    {
        while (audioSource1.volume < 1f)
{
        audioSource1.volume += Time.deltaTime / 5f;
        audioSource2.volume += Time.deltaTime / 5f;
        audioSource3.volume += Time.deltaTime / 5f;
        yield return null;
}
    }
}
