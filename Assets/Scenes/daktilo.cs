using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class daktilo : MonoBehaviour
{
    public Text Text_box;
    private string Message;
    private Coroutine textCoroutine;

    private void Start(){
        
        
        textCoroutine = StartCoroutine(Text_Player());

    }

    public void ImageChanged(){

        StopCoroutine(textCoroutine);
        Text_box.text = "Arda, sırasına kısa yoldan ulaşmak yerine tüm sınıfı dolaşarak sırasına oturur.";

        textCoroutine = StartCoroutine(Text_Player());
        
    }
    

    public IEnumerator Text_Player(){
        Message = Text_box.text;
        Text_box.text = "";
        foreach(char Character in Message){
            Debug.Log(Message);

            yield return new WaitForSeconds(0.05f);
            Text_box.text = Text_box.text + Character;
            
        }
    }

    


}
