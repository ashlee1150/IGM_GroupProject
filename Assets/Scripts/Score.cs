using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public int scoreCounter=0;
    private string scoreText;
    public int healthCounter = 5;
    private string healthText;
    public int seconds;
    private string secText;
    public int customerTarget;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer",0.0f,1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (seconds == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        
        else
        {
            //scoreText = "Score: " + scoreCounter.ToString()+ "/"+customerTarget.ToString();
            //GameObject.Find("Score Text").GetComponent<Text>().text = scoreText;
            //healthText = "Health: " + healthCounter.ToString() + "/5";
            //GameObject.Find("Health Text").GetComponent<Text>().text = healthText;
            if (seconds < 10)
            {
                secText = "Timer: 0:0" + seconds.ToString();
                GameObject.Find("Timer Text").GetComponent<Text>().text = secText;
            }
            else
            {
                secText = "Timer: 0:" + seconds.ToString();
                GameObject.Find("Timer Text").GetComponent<Text>().text = secText;
            }
            
        }
        
    }
    void timer()
    {
        seconds = seconds - 1;
    }
}
