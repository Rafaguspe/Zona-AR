using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class joelray : MonoBehaviour
{
    public Camera camera;
    public int FingerID = -1;
    private void Awake()
    {
        FingerID = 0;
        
    }

    // Update is called once per frame
    void Update()
    {


       

        if (EventSystem.current.IsPointerOverGameObject())    // is the touch on the GUI
        {
            Debug.Log("2");
        }
        else
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Debug.Log(objectHit.name);
                // Do something with the object that was hit by the raycast.
            }
        }

    }
}
