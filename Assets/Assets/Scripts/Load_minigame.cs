using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Load_minigame : MonoBehaviour
{
    
    public void OnMouseDown()
    {
        
       SceneManager.LoadScene("MiniGame");
        
    }

}
