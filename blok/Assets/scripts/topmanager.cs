using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class topmanager : MonoBehaviour
{
    public Rigidbody2D toprb;
    public float dikeyhiz, yatayhiz;
    
    kazandin kazandin;
    private void Awake()
    {
        kazandin = Object.FindObjectOfType<kazandin>();
    }
    private void Start()
    {
        toprb.velocity = new Vector2(Random.Range(-yatayhiz,yatayhiz), toprb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "player")
        {
            toprb.velocity = new Vector2(toprb.velocity.x, dikeyhiz);
        }
        else if(temas.gameObject.tag=="solduvar")
        {
            toprb.velocity = new Vector2(yatayhiz, toprb.velocity.y);
        }
        else if (temas.gameObject.tag == "ustduvar")
        {
            toprb.velocity = new Vector2(toprb.velocity.x, -dikeyhiz);
        }
        else if (temas.gameObject.tag == "sagduvar")
        {
          toprb.velocity = new Vector2(-yatayhiz, toprb.velocity.y);
        }
        else if (temas.gameObject.tag == "altduvar")
        {
            kazandin.yandin = true;
            kazandin.bitis();
        }
    }
}
