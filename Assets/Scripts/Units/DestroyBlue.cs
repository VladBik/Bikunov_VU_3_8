using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlue : MonoBehaviour
{
	public void Destroy()
	{
		var objs = GameObject.FindGameObjectsWithTag("VirusBlue"); //уничтожает с нужным тегом
		for (int i = 0; i < objs.Length; i++)
			Destroy(objs[i]);
	}
}
