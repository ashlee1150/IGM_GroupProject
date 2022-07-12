using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Score_zombie : MonoBehaviour {
	public float minhp = 0, success_currhp, success_currhpSlow, happiness_currhp, happiness_currhpSlow;
	public float maxhp = 100;
	public float increase = 10;
	public float damage = 10;
	public Image success_barfast, success_barslow, barfast, barslow;
	public Text scoreText;
	public int ballValue;
	public GameObject bomb;
	private Explode explodeScripts;

	private int score;

	// Use this for initialization
	void Start () {
		success_currhp = minhp;
		success_currhpSlow = minhp;
		happiness_currhp = maxhp;
		happiness_currhpSlow = maxhp;
		score = 0;
		explodeScripts = bomb.GetComponent<Explode>();
		UpdateScore ();
	}
	public float success_t = 0;
	public float damage_t = 0;

    void Update()
    {
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
    void OnTriggerEnter2D () {
		score += ballValue;
		success_currhp += increase;
		success_t = 0;
		happiness_currhp -= damage;
		damage_t = 0;
		if (success_currhp == 100)
		{
			SceneManager.LoadScene("Success_zombie");
		}
		
		UpdateScore ();
	}

	
	

	void UpdateScore () {
		scoreText.text = "Total Score\n" + score;
	}
}
