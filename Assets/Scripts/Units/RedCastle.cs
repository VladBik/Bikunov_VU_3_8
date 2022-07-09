using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCastle : MonoBehaviour
{

	public int livesRedCastle = 100;
	[SerializeField]
	private GameObject PlayAudioDeathC;
	[SerializeField]
	private GameObject ExplosionRedCastle;
	public ScoreManager scoreManager;
	public int scoreGreen;

	private void Start()
	{

		FindGameController();
		PlayAudioDeathC.SetActive(false);

	}

	private void FindGameController()
	{
		GameObject GameControllerObject = GameObject.FindWithTag("GameController");
		if (GameControllerObject != null)
		{
			scoreManager = GameControllerObject.GetComponent<ScoreManager>();
		}
		if (GameControllerObject == null)
		{
			Debug.Log("GameManager не найден");
		}
	}

	private void Update()
	{

		if (livesRedCastle <= 0)
		{
			DeathRedCastle();
		}
		else
		{
			return;
		}

	}

	private void DeathRedCastle()
	{
		PlayAudioDeathC.SetActive(true);
		ExplosionRedCastle.SetActive(true);
		scoreManager.AddScoreGreen(scoreGreen);
		Debug.Log("Красный замок пал!");
		Destroy(gameObject, 0.8f);
	}

	private void TakeDamageRedCastle()
	{
		livesRedCastle--;

		if (livesRedCastle < 0)
		{
			livesRedCastle = 0;
		}
	}

	private void OnTriggerEnter(Collider collision)
	{

		if (collision.tag == "VirusGreen")
		{
			TakeDamageRedCastle();
		}
		else if (collision.tag == null)
		{
			return;
		}
	}
}
