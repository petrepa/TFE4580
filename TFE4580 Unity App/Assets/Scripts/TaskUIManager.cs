using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject uiPanel;

    public void ShowTask(){
        uiPanel.SetActive(true);
    }

    public void CloseTask(){
        uiPanel.SetActive(false);
    }
}
