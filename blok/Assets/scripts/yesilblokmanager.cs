using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesilblokmanager : MonoBehaviour
{
    public int blokcan;
    public AudioSource a;
    public AudioClip b;
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "top")
        {
            a.PlayOneShot(b);
            kazandin.puan += 10;
            blokcan--;
          
        }
        if(blokcan==0)
        {
            Destroy(this.gameObject);
            kazandin.kirilanblok++;
        }
    }
}
