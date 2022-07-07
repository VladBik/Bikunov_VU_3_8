using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenPannelUI : MonoBehaviour
{
    [SerializeField]
    private GameObject Panel1;
    
    public void MoveGreenPanel()
    {
        Panel1.SetActive(true);
    }

    public void CloseGreenPanel()
    {
        Panel1.SetActive(false);
    }
}
