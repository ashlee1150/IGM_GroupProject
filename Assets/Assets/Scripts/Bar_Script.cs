using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bar_Script : MonoBehaviour
{
    // Start is called before the first frame update
    private float minhp = 0, success_currhp, success_currhpSlow,happiness_currhp, happiness_currhpSlow;
    private float maxhp = 100;
    public float increase = 10;
    public float damage = 10;
    public Image success_barfast, success_barslow, barfast, barslow;
    void Start()
    {
        success_currhp = minhp;
        success_currhpSlow = minhp;
        happiness_currhp = maxhp;
        happiness_currhpSlow = maxhp;
    }
    float success_t = 0;
    float damage_t = 0;

    // Update is called once per frame
    void Update()
    {
        if(success_currhpSlow != success_currhp)
        {
            success_currhpSlow = Mathf.Lerp(success_currhpSlow, success_currhp, success_t);
            success_t += 1.0f * Time.deltaTime;
        }
        success_barfast.fillAmount = success_currhp / maxhp;
        success_barslow.fillAmount = success_currhpSlow / maxhp;
        if (happiness_currhpSlow != happiness_currhp)
        {
            happiness_currhpSlow = Mathf.Lerp(happiness_currhpSlow, happiness_currhp, damage_t);
            damage_t += 1.0f * Time.deltaTime;
        }
        barfast.fillAmount = happiness_currhp / maxhp;
        barslow.fillAmount = happiness_currhpSlow / maxhp;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            
            success_currhp += increase;
            success_t = 0;
            happiness_currhp -= damage;
            damage_t = 0;
            if (success_currhp == 100)
            {
                SceneManager.LoadScene("Success_MG");
            }
            
        }
        else
        {
            Debug.Log("not working2");
        }
    }
}
