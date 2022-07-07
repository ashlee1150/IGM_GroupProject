using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unlocker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("LevelUnlocker") == null)
        {
            GameObject.Find("level2stuff").SetActive(false);
            Debug.Log("Is Null");
        }
        else
        {
            Debug.Log("not null");
            if (GameObject.Find("LevelUnlocker").GetComponent<DontDestroy>().isEnable == true)
            {
                GameObject.Find("Level 2 Btn").GetComponent<Button>().interactable = true;
                GameObject.Find("level2stuff").SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
