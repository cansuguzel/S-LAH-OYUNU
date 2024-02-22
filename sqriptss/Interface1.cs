using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour
{
    public Text zaman;
    public Text durum;
    public float zamanSayaci=180;
    public bool oyunDevam = true;
    public bool oyunTamam;
    public void yenidenOyna()
    {
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunDevam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";
        }
        else
        {
            durum.text = "oyun tamamlanamadý";
        }
        if(zamanSayaci<0)
        {
            oyunDevam = false;
            durum.text = "oyun tamamlanamadý";
            yenidenOyna();

        }
    }
}
