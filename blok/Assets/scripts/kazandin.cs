using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class kazandin : MonoBehaviour
{
    public GameObject player,top;
    public TextMeshProUGUI yazi, skoryazi, blokyazi, tekraryazi,puanyazi;
    public Transform bloklar;
    int bloksayisi;
    public static int puan;
    public static int kirilanblok;
    public bool yandin=false;
    // Start is called before the first frame update
    void Start()
    {
        puan = 0;
        kirilanblok = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        bitis();
    }
    public void bitis()
    {
        puanyazi.text = "Skor : " + puan.ToString();
        bloksayisi = bloklar.childCount;
        if (bloksayisi == 0 || yandin)
        {
            if(!yandin)
            {
                yazi.text = "Kazandın";
            }
            else if(yandin)
            {
                yazi.text = "Kaybettin";
            }
           
            skoryazi.text = "Skor : " + puan.ToString();
            blokyazi.text = "Kırılan Blok : " + kirilanblok.ToString();
            tekraryazi.text = "Tekrar Oynamak İçin Bir Tuşa Basınız";
            puanyazi.text = "";
            Destroy(player);
            Destroy(top);
            Time.timeScale = 0;
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1;

            }
        }
    }
}
