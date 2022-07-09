using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEmpty : MonoBehaviour
{
	
	private void Update()
    {
		DestroyThis();

	}
	
	
	public void DestroyThis()
	{
		Destroy(gameObject, 10f);
	}
}
