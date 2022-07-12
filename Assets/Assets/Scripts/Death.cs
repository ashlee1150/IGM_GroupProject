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


    public void Bat()
    {
        SceneManager.LoadScene("MiniGame");
    }
    
    public void zombie()
    {
        SceneManager.LoadScene("Minigame_Zombie");
    }
    public void ghost()
    {
        SceneManager.LoadScene("GameGhost");
    }
    public void minigame()
    {
        SceneManager.LoadScene("Choose_MiniGame");
    }
    public void minigame2()
    {
        SceneManager.LoadScene("Choose_MiniGame2");
    }
    public void minigame3()
    {
        SceneManager.LoadScene("Choose_MiniGame3");
    }
    public void ending()
    {
        SceneManager.LoadScene("ENDING");
    }
}
