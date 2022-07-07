using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_tag : MonoBehaviour
{
    // Start is called before the first frame update
    public string newTag;
    //public Text TagText;
    //public AudioSource coinSource;
    public int key;
    void Start()
    {
        gameObject.tag = "active";
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameObject.tag = newTag;
            //TagText.text = newTag;
        }
    }
}
