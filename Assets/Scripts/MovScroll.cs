using System.Collections;
using System.Collections.Generic;
using UnityEngine;








public class MovScroll : MonoBehaviour
{
	
	public GameObject escrol,conte;
	public Vector3 posi;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
	     posi =conte.transform.position;
    }

    // Update is called once per frame
    void Update()
	{
		
    	
		if (Input.touchCount ==1)
		{
			//variable para el dedo que toca la pantalla
			Touch dedo = Input.GetTouch(0);
			
			Debug.Log("Nuevo pos Contenedor "+conte.transform.position);
			
			if (dedo.phase == TouchPhase.Canceled)
			{
				Debug.Log(conte.transform.position);
				posi= conte.transform.position;
			}
			
			
		}
    	
        
    }
}
