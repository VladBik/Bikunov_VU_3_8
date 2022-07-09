using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBlue : MonoBehaviour
{
	private Image HealthBarBlueCastle;
	public float CurrentHealth;
	private float MaxHealth = 100f;
	BlueCastle Castle;

	private void Start()
    {
		HealthBarBlueCastle = GetComponent<Image>();
		Castle = FindObjectOfType<BlueCastle>();
    }

	private void Update()
    {
		CurrentHealth = Castle.livesBlueCastle;
		HealthBarBlueCastle.fillAmount = CurrentHealth / MaxHealth;
    }
	
	

}