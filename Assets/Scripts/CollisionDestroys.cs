using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionDestroys : MonoBehaviour
{
    
    // Start is called before the first frame update

    void Start()
    {
        //coinSource = GetComponent<AudioSource>();
        //gameObject.tag = "active";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //if we enter a collision and the object we collided with is tagged item
        //destroy the gameobject we hit
        if (col.gameObject.tag == "item" )
        {
            //coinSource.Play();
            /// Debug.Log("Played sound");

            //Destroy(GameObject.FindGameObjectWithTag("item"));
            //Destroy(col.gameObject);
            GameObject.FindGameObjectWithTag("item").SetActive(false);
            Debug.Log("disabled");
            //coinSource.Play();
        }else if (col.gameObject.tag == "item2")
        {
            GameObject.FindGameObjectWithTag("item2").SetActive(false);

        }
        else if(col.gameObject.tag == "item3")
        {
            GameObject.FindGameObjectWithTag("item3").SetActive(false);

        }
        else if(col.gameObject.tag == "item4")
        {
            GameObject.FindGameObjectWithTag("item4").SetActive(false);

        }
        else if(col.gameObject.tag == "item5")
        {
            GameObject.FindGameObjectWithTag("item5").SetActive(false);

        }
        else if (col.gameObject.tag == "item6")
        {
            GameObject.FindGameObjectWithTag("item6").SetActive(false);

        }
        else if (col.gameObject.tag == "item7")
        {
            GameObject.FindGameObjectWithTag("item7").SetActive(false);

        }
        else if (col.gameObject.tag == "item8")
        {
            GameObject.FindGameObjectWithTag("item8").SetActive(false);

        }
        else if (col.gameObject.tag == "item9")
        {
            GameObject.FindGameObjectWithTag("item9").SetActive(false);

        }
        else if (col.gameObject.tag == "item10")
        {
            GameObject.FindGameObjectWithTag("item10").SetActive(false);

        }
        else if( col.gameObject.tag == "key_white" )
        {
            
            GameObject.FindGameObjectWithTag("key_white").SetActive(false);
            

        }else if(col.gameObject.tag == "red_key")
        {
            GameObject.FindGameObjectWithTag("red_key").SetActive(false);
        }
        else if(col.gameObject.tag == "green_key")
        {
            GameObject.FindGameObjectWithTag("green_key").SetActive(false);

        }

    }
}

