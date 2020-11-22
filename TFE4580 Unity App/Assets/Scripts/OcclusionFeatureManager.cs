using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class OcclusionFeatureManager : MonoBehaviour
{
    [SerializeField]
    private GameObject OcclusionManagerObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("From script - OcclusionBool: " + GlobalVariableStorage.OcclusionBool);
        
        if ( GlobalVariableStorage.OcclusionBool ){
            OcclusionManagerObject.GetComponent<AROcclusionManager>().enabled = true;
            Debug.Log("Turned ON AROcclusionManager");
        }else{
            OcclusionManagerObject.GetComponent<AROcclusionManager>().enabled = false;
            Debug.Log("Turned OFF AROcclusionManager");
        }
    }
}
