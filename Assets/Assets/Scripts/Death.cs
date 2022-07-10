using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void loaddeath()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void minigame()
    {
        SceneManager.LoadScene("Choose_MiniGame");
    }
    public void ending()
    {
        SceneManager.LoadScene("ENDING");
    }
}
