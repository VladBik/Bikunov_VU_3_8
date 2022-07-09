using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCastle : MonoBehaviour
{

	public int livesBlueCastle = 100;
	[SerializeField]
	private GameObject PlayAudioDeathC;
	[SerializeField]
	private GameObject ExplosionBlueCastle;
	public ScoreManager scoreManager;
	public int scoreRed;

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

		if (livesBlueCastle <= 0)
		{
			DeathBlueCastle();
		}
		else
		{
			return;
		}

	}

	private void DeathBlueCastle()
	{
		PlayAudioDeathC.SetActive(true);
		ExplosionBlueCastle.SetActive(true);
		scoreManager.AddScoreRed(scoreRed);
		Debug.Log("Синий замок пал!");
		Destroy(gameObject, 0.8f);
	}

	private void TakeDamageBlueCastle()
	{
		livesBlueCastle--;

		if (livesBlueCastle < 0)
		{
			livesBlueCastle = 0;
		}
	}

	private void OnTriggerEnter(Collider collision)
	{

		if (collision.tag == "VirusRed")
		{
			TakeDamageBlueCastle();
		}
		else if (collision.tag == null)
		{
			return;
		}
	}
}
