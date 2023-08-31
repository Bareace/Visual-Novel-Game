using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne2 : MonoBehaviour
{
    static bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(){
        SceneManager.LoadScene("1.a");
        
    }
    public void LoadScene2(){
        SceneManager.LoadScene("1.a_devam");
    }
    public void LoadScene3(){
        SceneManager.LoadScene("1.a.a");
        flag = true;
    }
    public void LoadScene4(){
        SceneManager.LoadScene("bölüm2");
    }

    public void LoadScene5(){
        SceneManager.LoadScene("kapı");
    }
    public void LoadScene6()
{
    SceneManager.LoadScene("bölüm3");
    
}
    public void LoadScene7(){
        SceneManager.LoadScene("teneffüs");
    }
    public void LoadScene8(){
        SceneManager.LoadScene("3.a");
    }
    public void LoadScene9(){
        SceneManager.LoadScene("3.b");
    }
    public void LoadScene10(){
        SceneManager.LoadScene("1");
    }
    public void LoadScene11(){
        if (flag == true){
            SceneManager.LoadScene("3.a");
        }else{
            SceneManager.LoadScene("3.b");
        }
        
    }
    public void LoadScene12(){
        SceneManager.LoadScene("3_devam");
    }
    public void LoadScene13(){
        SceneManager.LoadScene("çömelmek");
    }
    public void LoadScene14(){
        SceneManager.LoadScene("otizm");
    }
    public void LoadScene15(){
        SceneManager.LoadScene("saat");
    }
    public void LoadScene16(){
        SceneManager.LoadScene("zil");
    }
    public void LoadScene17(){
        SceneManager.LoadScene("pov_bitiş");
    }
    public void LoadScene18(){
        SceneManager.LoadScene("dönüş");
    }
    public void LoadScene19(){
        SceneManager.LoadScene("hocam");
    }
    public void LoadScene20(){
        SceneManager.LoadScene("giris");
    }
    public void LoadScene21(){
        SceneManager.LoadScene("son");
    }

}
