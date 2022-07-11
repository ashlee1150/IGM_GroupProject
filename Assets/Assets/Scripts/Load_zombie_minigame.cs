using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Load_zombie_minigame : MonoBehaviour
{
    public void OnMouseDown()
    {

        SceneManager.LoadScene("Minigame_Zombie");

    }
}
