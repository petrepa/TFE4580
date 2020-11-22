using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

[RequireComponent(typeof(ARPlaneManager))]
public class PlaneVisualization : MonoBehaviour
{    
    private ARPlaneManager planeManager;

    private void Awake() {
        planeManager = GetComponent<ARPlaneManager>();
   }

    public void TogglePlaneVisualizer(bool newValue){
        if(newValue){
            planeManager.enabled = true;
            Debug.Log("Plane manager turned ON");
        }else{
            planeManager.enabled = false;

            foreach (var plane in planeManager.trackables){
                plane.gameObject.SetActive(false);
            }

            Debug.Log("Plane manager turned OFF");
        }
    }
    
}
