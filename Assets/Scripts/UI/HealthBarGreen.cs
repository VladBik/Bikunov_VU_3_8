using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarGreen : MonoBehaviour
{
	private Image HealthBarGreenCastle;
	public float CurrentHealth;
	private float MaxHealth = 100f;
	GreenCastle CastleGreen;

	private void Start()
    {
		HealthBarGreenCastle = GetComponent<Image>();
		CastleGreen = FindObjectOfType<GreenCastle>();
    }

	private void Update()
    {
		CurrentHealth = CastleGreen.livesGreenCastle;
		HealthBarGreenCastle.fillAmount = CurrentHealth / MaxHealth;
    }
	
	

}