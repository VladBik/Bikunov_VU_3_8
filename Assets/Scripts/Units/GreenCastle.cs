using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCastle : MonoBehaviour
{

	public int livesGreenCastle = 100;
	[SerializeField]
	private GameObject PlayAudioDeathC;
	[SerializeField]
	private GameObject ExplosionGreenCastle;
	public ScoreManager scoreManager;
	public int scoreBlue;

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

		if (livesGreenCastle <= 0)
		{
			DeathGreenCastle();
		}
		else
		{
			return;
		}

	}

	private void DeathGreenCastle()
	{
		PlayAudioDeathC.SetActive(true);
		ExplosionGreenCastle.SetActive(true);
		scoreManager.AddScoreBlue(scoreBlue);
		Debug.Log("Зеленый замок пал!");
		Destroy(gameObject, 0.8f);
	}

	private void TakeDamageGreenCastle()
	{
		livesGreenCastle--;

		if (livesGreenCastle < 0)
		{
			livesGreenCastle = 0;
		}
	}

	private void OnTriggerEnter(Collider collision)
	{

		if (collision.tag == "VirusBlue")
		{
			TakeDamageGreenCastle();
		}
		else if (collision.tag == null)
		{
			return;
		}
	}
}
