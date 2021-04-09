using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maviblokmanager : MonoBehaviour
{
    public int blokcan;
    private MeshRenderer ressam;
    public Material kirik;
    public AudioSource a;
    public AudioClip b;
    private void Start()
    {
        ressam = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "top")
        {
            a.PlayOneShot(b);
            kazandin.puan += 15;
            blokcan--;
           
        }
        if (blokcan == 1)
        {
            ressam.material = kirik;
        }
        if (blokcan == 0)
        {
            Destroy(this.gameObject);
            kazandin.kirilanblok++;
        }
    }
}
