using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMan : MonoBehaviour
{
    public static bool isGameOver;
    //public GameObject gameOverScreen;
    private void Awake()//just before function 
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            //gameOverScreen.SetActive(true);
            SceneManager.LoadScene("Death_Screen");
        }
    }
}
