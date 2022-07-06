using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScr1 : MonoBehaviour
{
    public GameObject Panel1;
    
    public void MovePanel1()
    {
        Panel1.SetActive(true);
    }

    public void ClosePanel2()
    {
        Panel1.SetActive(false);
    }
}
