using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kraker : MonoBehaviour
{
    public Image targetImage; 
    public Sprite newSprite;
    public GameObject text_bar; 
    public GameObject button_cont;
    public GameObject button_cont2;
    public GameObject button_cont3;
    public GameObject button_cont4;
    public GameObject button_cont5;
    public Text Text_box;




    
    // Drag the Image GameObject in the Unity Inspector      // Drag the new Sprite in the Unity Inspector      // Call this method to change the image     
    // Start is called before the first frame update

    void Start()
    {
        text_bar.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImage()    
    {   
        Text_box.text = "Barış: \n \t -Ben o Suriyelinin dokunduğu şeyden yemem.";
        button_cont3.SetActive(false);      
        targetImage.sprite = newSprite;     
        button_cont.SetActive(false);
        button_cont2.SetActive(true);
        button_cont4.SetActive(false);
        button_cont5.SetActive(false);

    }
    public void ChangeImage2()    
    {         
        Text_box.text = "Esad bu söze çok sinirlenir ve Barış'ın üzerine atılır.";
        targetImage.sprite = newSprite;     
        button_cont.SetActive(false);
        button_cont2.SetActive(false);
        button_cont3.SetActive(true);
        button_cont4.SetActive(false);
        button_cont5.SetActive(false);

    }
    public void ChangeImage3()    
    {         
        Text_box.text = "(Olaya müdahele edersin.)";
        targetImage.sprite = newSprite;     
        button_cont2.SetActive(false);
        button_cont3.SetActive(false);
        button_cont.SetActive(false);
        button_cont4.SetActive(true);
        button_cont5.SetActive(false);

    }
    public void ChangeImage4()    
    {         
        Text_box.text = "Sen: \n \t -Esad sakinleş.";
        targetImage.sprite = newSprite;     
        button_cont.SetActive(false);
        button_cont2.SetActive(false);
        button_cont3.SetActive(false);
        button_cont.SetActive(false);
        button_cont4.SetActive(false);
        button_cont5.SetActive(true);

    }
}
