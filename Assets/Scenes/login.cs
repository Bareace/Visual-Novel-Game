using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public static string name;
    public Text text1;

    
    void Start(){

    }
    void Update(){

    }




    public void GetInputText()
    {
        name = text1.text;
    }
}