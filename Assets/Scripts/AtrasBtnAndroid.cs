using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtrasBtnAndroid : MonoBehaviour
{
	
	
	Manager mana;
    // Start is called before the first frame update
    void Start()
    {
	    mana=GameObject.FindGameObjectWithTag("TagMana").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
	    if (Input.GetKeyDown (KeyCode.Escape))
	    {
	    	
		    int ven=  mana.ventana;
		    
		    switch (ven)
		    {
		    case 1: 
			    Application.Quit();
			    break;
		   
		    case 2: 
			    //  StartCoroutine(mana.back());
			    mana.back();
			    mana.ventana=1;
			    break;
			    
		    case 3: 
			    // StartCoroutine( mana.Iniciox3D());
			    mana.Iniciox3D();
			    //mana.CerrarEmpresaRay();
			    mana.ventana=1;
			    break;    
		   
		    case 4: 
			    // StartCoroutine(mana.Volver2D());
			      mana.Volver2D();
			    mana.ventana=2;
			    break; 
			    
		    case 5: 
			    //  StartCoroutine(mana.Volver3D());
			    mana.Volver3D();
			    mana.ventana=3;
			    
			    break;  
		    }// fin switch ven
	    	
	    	
	    	
	    	
	    }// fin tecla escape
        
        
        
    }
}
