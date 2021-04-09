using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{
    public float harekethizi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>=-8f && transform.position.x <=8f )
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(harekethizi * Time.deltaTime, 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-harekethizi * Time.deltaTime, 0f, 0f);
            }
        }
        else if(transform.position.x<-8f)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(harekethizi * Time.deltaTime, 0f, 0f);
            }
            
        }
        else if (transform.position.x > 8f)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-harekethizi * Time.deltaTime, 0f, 0f);
            }

        }
       


    }
}
