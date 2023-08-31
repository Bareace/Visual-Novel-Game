using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tepki : MonoBehaviour
{
    public Text Text_box;
    public GameObject button_a;
    public GameObject button_b;
    public GameObject button_cont;
    // Start is called before the first frame update
    void Start()
    {
        button_a.SetActive(true);
        
        button_b.SetActive(true);

        button_cont.SetActive(false);

        
    }
    public void ContTepki(){
        Text_box.text = "Sen: \n \t -Size ne bu konudan, önünüze dönün.";
        button_a.SetActive(false);
        button_b.SetActive(false);
        button_cont.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
