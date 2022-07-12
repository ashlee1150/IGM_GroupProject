using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Explode : MonoBehaviour {
	
	private Image success_barfast, success_barslow, barfast, barslow;
	
	private GameObject score_zombie;
	
	private Score_zombie script;
	public ParticleSystem[] effects;
	public GameObject explosion;
	void Start()
	{
		score_zombie = GameObject.Find("Hat");
		barfast = GameObject.Find("Happiness_Bar (1)").GetComponent<Image>();
		barslow = GameObject.Find("Happiness_Bar (2)").GetComponent<Image>();
		success_barfast = GameObject.Find("Success_Bar (1)").GetComponent<Image>();
		success_barslow = GameObject.Find("Success_Bar (2)").GetComponent<Image>();
		script = score_zombie.GetComponent<Score_zombie>();
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag == "Hat") {
			
			script.success_currhp -= script.increase;
			script.success_t = 0;
			script.happiness_currhp += script.damage;
			script.damage_t = 0;

			Instantiate (explosion, transform.position, transform.rotation);
			foreach (var effect in effects) {
				effect.transform.parent = null;
				effect.Stop ();
				Destroy (effect.gameObject, 1.0f);
			}
			Destroy (gameObject);
		}
	}
}
