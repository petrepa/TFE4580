using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void InfoScene(){
        SceneManager.LoadScene("Info");
    }

    public void MainScene(){
        SceneManager.LoadScene("Main");
    }

    public void FinishedScene(){
        SceneManager.LoadScene("Finished");
    }

    public void AREnvScene(){
        SceneManager.LoadScene("AREnv");
    }
}
