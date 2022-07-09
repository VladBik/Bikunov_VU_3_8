using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	private Image HealthBarRedCastle;
	public float CurrentHealth;
	private float MaxHealth = 100f;
	RedCastle Castle;

	private void Start()
    {
		HealthBarRedCastle = GetComponent<Image>();
		Castle = FindObjectOfType<RedCastle>();
    }

	private void Update()
    {
		CurrentHealth = Castle.livesRedCastle;
		HealthBarRedCastle.fillAmount = CurrentHealth / MaxHealth;
    }
	
	

}