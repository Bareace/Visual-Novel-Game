using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class color_changer : MonoBehaviour
{
    public Color newColor;
    public Image image;

    void Start()
    {
        newColor = image.color;
        newColor.a = 0f; // A değerini 0.5 olarak değiştirin
        image.color = newColor;
        StartCoroutine("IncreaseAlpha");
    }

    IEnumerator IncreaseAlpha()
    {
        while (newColor.a < 1f)
        {
            newColor.a += Time.deltaTime / 5f;
            image.color = newColor;
            yield return null;
        }
    }
}