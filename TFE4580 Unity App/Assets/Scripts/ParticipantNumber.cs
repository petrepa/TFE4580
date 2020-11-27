using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticipantNumber : MonoBehaviour
{
    const string glyphs= "ABCDEFGHIJKLMNOP0123456789"; //add the characters you want
    private Text text;

    void Start(){
        text = GetComponent<Text>();
        var partNum = "";
        
        for(int i=0; i<4; i++)
        {
            partNum += (glyphs[Random.Range(0, glyphs.Length)]).ToString();
        }

        text.text = "#" + partNum;
    }
}