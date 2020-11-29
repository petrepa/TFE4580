using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUp : MonoBehaviour
{
    const string characters= "ABCDEFGHIJKLMNOP0123456789"; //add the characters you want
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<4; i++)
        {
            GlobalVariableStorage.ParticipantNumberString += (characters[Random.Range(0, characters.Length)]).ToString();
        }

        SceneManager.LoadScene("Main");
    }
}
