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

    public void AREnvScene(bool OcclusionFeature){
        GlobalVariableStorage.OcclusionBool = OcclusionFeature;
        SceneManager.LoadScene("AREnv");
        Debug.Log("GlobalVariableStorage.OcclusionBool: " + GlobalVariableStorage.OcclusionBool);
        Debug.Log("OcclusionFeature: " + OcclusionFeature);
    }

    
}
