using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BluePanelUI : MonoBehaviour
{
    [SerializeField]
    private GameObject BluePanel;
    
    public void MoveBluePanel()
    {
        BluePanel.SetActive(true);
    }

    public void CloseBluePanel()
    {
        BluePanel.SetActive(false);
    }
}
