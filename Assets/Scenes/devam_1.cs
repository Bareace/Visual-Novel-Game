using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class devam_1 : MonoBehaviour
{
    public Text Text_box;
    public GameObject button_a;
    public GameObject button_b;

    public GameObject button_cont;
    // Start is called before the first frame update
    void Start()
    {
        button_a.SetActive(false);
        
        button_b.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ContScene_1()
    {
        Text_box.text = "Barış: \n \t -Şu Suriyeli çocuk hakkındakileri duydun mu?";
        button_a.SetActive(true);

        button_b.SetActive(true);
        
        button_cont.SetActive(false);
    }
    public void ContScene_2()
    {
        Text_box.text = "Kalabalığı dağıtmaya ...";
        button_a.SetActive(true);

        button_b.SetActive(true);
        
        button_cont.SetActive(false);
    }

    
}
