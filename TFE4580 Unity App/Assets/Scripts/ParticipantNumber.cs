using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticipantNumber : MonoBehaviour
{
    private Text text;

    void Start(){
        text = GetComponent<Text>();

        text.text = "#" + GlobalVariableStorage.ParticipantNumberString;
    }
}