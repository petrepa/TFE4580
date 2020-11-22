using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject uiPanel;

    [SerializeField]
    private Button TaskButton;

    public void ShowTask(){
        // Open the task UI
        uiPanel.SetActive(true);
    }

    public void CloseTask(){
        // Close the task UI
        uiPanel.SetActive(false);

        // Change the color of the task button to indicate that the task has been seen
        TaskButton.GetComponent<Image>().color = new Color32(188, 208, 37, 255); // NTNUs green supporting color
    }
}
