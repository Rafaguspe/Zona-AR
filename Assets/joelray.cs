using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class joelray : MonoBehaviour
{
	public Camera arcamera;
	public TextMeshProUGUI descripcion;
	bool activo=false;
	Manager mana;
	public int FingerID = -1;
	private LineRenderer touchLine;
    
	Touch touch;
    
    
    
    private void Awake()
    {
        FingerID = 0;
        
    }
    
    
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		if(arcamera == null)    arcamera = Camera.main;
		mana=GameObject.FindGameObjectWithTag("TagMana").GetComponent<Manager>();
		
	
	}
    
	
    

    // Update is called once per frame
    void Update()
    {


	    /*

        if (EventSystem.current.IsPointerOverGameObject())    // is the touch on the GUI
        {
	        Debug.Log("2");
	        string F= "Esto es UI";
	        descripcion.text=F;
	        return;
	        
	    }*/
	    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
	    {
		    if(EventSystem.current.IsPointerOverGameObject())
		    {
		    	Debug.Log("2");
			    string F= "Esto es UI";
			    descripcion.text=F;
			    return;
		    	
		    }
		    else
			    {
			    	
			    RaycastHit hit;
			    Touch touch = Input.GetTouch(0);
			    Ray ray = arcamera.ScreenPointToRay(touch.position);
			    descripcion.text="No UI";

			    if (touch.phase == TouchPhase.Began) {

			
				
				
				
				    RaycastHit hitObject;
				
				
		
				    if (Physics.Raycast(ray,out hitObject) ) {
					
					    //Descripcion.text= "if del raycast";
					    string nam;
					    nam=hitObject.transform.name;
					
					
					    //	var posicionTouch = touch.position;
					
					
					
					
					
					
					
					    //hitObject.transform.localScale *= 1.2f;
					    if(activo==false&&nam=="BtnAurora" 
						    ||activo==false&&nam=="BtnAurora1" 
						    ||activo==false&&nam=="BtnAurora2" 
						    ||activo==false&&nam=="BtnAurora3" 
						    ||activo==false&&nam=="BtnAurora4"
						    ||activo==false&&nam=="BtnAmle" 
						    ||activo==false&&nam=="BtnComedor"
						    ||activo==false&&nam=="BtnDispensario"
						    ||activo==false&&nam=="BtnT-eco"
						    ||activo==false&&nam=="BtnLigna"
						    ||activo==false&&nam=="BtnControlEng"
						    ||activo==false&&nam=="BtnAdministracion"
						    ||activo==false&&nam=="Cube"
			
					    ){
							
						
						
						    if (nam=="BtnAurora"||nam=="BtnAurora1"||nam=="BtnAurora2"||nam=="BtnAurora3"||nam=="BtnAurora4")
						    {


					     
		
			
							    mana.EmpresaRay(4);
						    }

						    if (nam=="BtnComedor")
						    {
					       
		
							    mana.		EmpresaRay	(1);
							    //				StartCoroutine(mana.				Empresa	(1,5));
							    //						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						    }


						    if (nam=="BtnDispensario")
						    {
					       

							    //					Reubica.SetActive(false);
							    //					Atras3D.SetActive(false);
			
							    mana.		EmpresaRay(2);
							    //				StartCoroutine(				mana.				Empresa	(2,5));
							    //						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						    }


						    if (nam=="BtnT-eco")
						    {
							    mana.		EmpresaRay(3);
							    //				StartCoroutine(				mana.				Empresa	(3,5));
							    //						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						    }


						    if (nam=="BtnAmle")
						    {
					      

							    //					Reubica.SetActive(false);
							    //					Atras3D.SetActive(false);
			
							    //					Nombre.text="caso1";
							    mana.		EmpresaRay(6);
							    //				StartCoroutine(				mana.				Empresa	(6,5));
							    //					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						    }

						    if (nam=="BtnLigna")
						    {
					     

							    //					Reubica.SetActive(false);
							    //					Atras3D.SetActive(false);
							    mana.		EmpresaRay(7);
			
							    //				StartCoroutine(				mana.				Empresa	(7,5));
							    //					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						    }

						    if (nam=="BtnControlEng")
						    {
					      

							    //					Reubica.SetActive(false);
							    //					Atras3D.SetActive(false);
							    mana.		EmpresaRay(8);
			
			
							    //StartCoroutine(				mana.				Empresa	(8,5));
							    //					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						    }


						    if (nam=="BtnAdministracion")
						    {
					     
							    //					Reubica.SetActive(false);
							    //					Atras3D.SetActive(false);
			
							    //					Nombre.text="caso1";
							    mana.		EmpresaRay(5);
	

						    }


						
					    }
				    }
				    else
				    {
					    // Destroy(touchLine.gameObject,1f);
					    //  StartCoroutine(DestroyLineSmoothly(touchLine));
				    }
			    }//fin touch began 
			    }
	       
     

        }// fin un dedo
    
    
    
    
    
    }//fin Update














    }

