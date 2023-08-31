using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class kayıt : MonoBehaviour
{


public string filePath;


    // Update is called once per frame
    void Update()
    {
        
    }
    

public void Start()
{
    

}

public void StartGame()
{
    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string filePath = Path.Combine(desktopPath, login.name + ".txt");

    if (!File.Exists(filePath))
    {
        // Dosya yoksa yeni bir dosya oluşturuluyor.
        using (FileStream fs = File.Create(filePath))
        {
            fs.Close();
        }
    }
}
    
public void SaveToTexta()
{
    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string filePath = Path.Combine(desktopPath, login.name + ".txt");

    // FileStream nesnesi oluşturuluyor.
    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
    {
        // StreamWriter nesnesi oluşturuluyor.
        using (StreamWriter sw = new StreamWriter(fs))
        {
            // Veri dosyaya yazılıyor.
            sw.Write("a,");
            sw.Close();
        }

    }
    
}
public void SaveToTextb()
{
    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string filePath = Path.Combine(desktopPath, login.name + ".txt");

    // Seçim text dosyasına b yazılıyor.

    // FileStream nesnesi oluşturuluyor.
    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
    {
        // StreamWriter nesnesi oluşturuluyor.
        using (StreamWriter sw = new StreamWriter(fs))
        {
            // Veri dosyaya yazılıyor.
            sw.Write("b,");
            sw.Close();
        }

    }
    
    
}
}
