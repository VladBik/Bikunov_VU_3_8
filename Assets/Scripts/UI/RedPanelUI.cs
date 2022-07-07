using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedPanelUI : MonoBehaviour
{
        [SerializeField]
    private GameObject RedPanel;
    
    public void MoveRedPanel()
    {
        RedPanel.SetActive(true);
    }

    public void CloseRedPanel()
    {
        RedPanel.SetActive(false);
    }
}
