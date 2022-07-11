using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Ghost : MonoBehaviour {

    public int score;
    public Text scoreDisplay;
    private float minhp = 0, success_currhp, success_currhpSlow, happiness_currhp, happiness_currhpSlow;
    private float maxhp = 100;
    public float increase = 1;
    public float damage = 1;
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

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        if (success_currhpSlow != success_currhp)
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
        success_currhp += increase;
        success_t = 0;
        happiness_currhp -= damage;
        damage_t = 0;
        if (success_currhp == 100)
        {
            SceneManager.LoadScene("Success_Ghost");
        }
    }
}
