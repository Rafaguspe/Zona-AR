using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//Joel
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class UIBloquea : MonoBehaviour {
    
    

	public GameObject penderPanel;
	public GameObject objetoIns;
	public TMP_Text Descripcion;
	bool activo=false;
	//joel 
	private int fingerID = -1;
	
	
	//	[SerializeField] float RotationSpeed = 2f;
	bool dragging = false;
	Rigidbody rb; 
	
	
	
	Manager mana;
	UI_HoldButton Presionado;

	//Agregado por Marlon

	


	[SerializeField]
	[Tooltip("Camera for raycast, default is Camera which tagged as MainCamera")]
	public Camera arCamera;
	[SerializeField]
	[Tooltip("Material of Drawn Raycast line")]
	private Material lineMaterial;
	private LineRenderer viewLine;
	private LineRenderer touchLine;
	
	
	
	//joel
	protected void Awake()
	{
		#if !UNITY_EDITOR
		fingerID = 0; 
        #endif
	}
	
	
	void Start()
	{
		if(arCamera == null)    arCamera = Camera.main;
		mana=GameObject.FindGameObjectWithTag("TagMana").GetComponent<Manager>();
		Presionado=GameObject.FindGameObjectWithTag("TagPresionado").GetComponent<UI_HoldButton>();

		//viewLine = CreateLine("ViewLine", Color.red);
       
	}
	
	void OnMouseDrag()
	{
		dragging = true;
	}


	private bool IsPointerOverUIObject()
	{
			Touch touch = Input.GetTouch(0);
		PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
			eventDataCurrentPosition.position=new Vector2(touch.position.x,touch.position.y);
		//eventDataCurrentPosition.position=new Vector2(Input.mousePosition.x,Input.mousePosition.y);
		List<RaycastResult> results= new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventDataCurrentPosition,results);
		return results.Count >0;
		
	}





    // Update is called once per frame
    void Update()
	{
    	
    	
		Vector3 ubi3= arCamera.transform.position;
		
		string ubi= ubi3.ToString();
	
		
		//Descripcion.text= ubi;
		
		
	
		
		
		if(Input.GetMouseButtonUp (0))
		{
			dragging = false; 
		}



		// Touch raycast
		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch(0);
			var touchPositon = touch.position;


			Ray touchRay = arCamera.ScreenPointToRay(touchPositon);
			
			
			switch (touch.phase)
			{
			case TouchPhase.Began:
				touchLine = CreateLine("touchLine",Color.clear);
				touchLine.SetPosition(0,touchRay.origin - new Vector3(0,0.1f,0));
				touchLine.SetPosition(1,touchRay.direction*10f);
				
				break;
			case TouchPhase.Ended :
			case TouchPhase.Canceled :
				Destroy(touchLine.gameObject,1f);
				StartCoroutine(DestroyLineSmoothly(touchLine));
				
				break;
			case TouchPhase.Moved :
				//case TouchPhase.Stationary :
				touchLine.SetPosition(1,touchRay.direction*10f);
				
				break;
			}

			
    	
    	
    	
			if (IsPointerOverUIObject())
		{
			//Cuando se toca la UI
			
			if (Input.touchCount==1 && Input.GetTouch(0).phase== TouchPhase.Began)
			{
				Descripcion.text=" UI";
				Debug.Log("IF dentro UI");
				Destroy(touchLine.gameObject,1f);
				StartCoroutine(DestroyLineSmoothly(touchLine));
				return;
			}
			
			
			
			
		}// fin is !pointer
		
		else
			{
			
			switch (touch.phase)
			{
			case TouchPhase.Began:
				touchLine = CreateLine("touchLine",Color.clear);
				touchLine.SetPosition(0,touchRay.origin - new Vector3(0,0.1f,0));
				touchLine.SetPosition(1,touchRay.direction*10f);
				
				break;
			case TouchPhase.Ended :
			
			case TouchPhase.Moved :
				//case TouchPhase.Stationary :
				touchLine.SetPosition(1,touchRay.direction*10f);
				
				break;
			}

			
			
			// Cuando no se toca la UI
			if (Input.touchCount==1 && Input.GetTouch(0).phase== TouchPhase.Began)
			{
				Debug.Log("IF fuera  UI");
				
				//		if (touch.phase == TouchPhase.Began) {

			
				
				
				
				RaycastHit hitObject;
				
				
		
				if (Physics.Raycast(touchRay,out hitObject) ) {
					
					//Descripcion.text= "if del raycast";
					string nam;
					nam=hitObject.transform.name;
					Descripcion.text="No UI";
					
			
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


							Presionado.IsHolding=false;
		
			
							mana.EmpresaRay(4);
						}

						if (nam=="BtnComedor")
						{
							Presionado.IsHolding=false;
		
							mana.		EmpresaRay	(1);
							//				StartCoroutine(mana.				Empresa	(1,5));
							//						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnDispensario")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			
							mana.		EmpresaRay(2);
							//				StartCoroutine(				mana.				Empresa	(2,5));
							//						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnT-eco")
						{
							Presionado.IsHolding=false;
							//						Reubica.SetActive(false);
							//						Atras3D.SetActive(false);
			
							//				Nombre.text="caso1";
							mana.		EmpresaRay(3);
							//				StartCoroutine(				mana.				Empresa	(3,5));
							//						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnAmle")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			
							//					Nombre.text="caso1";
							mana.		EmpresaRay(6);
							//				StartCoroutine(				mana.				Empresa	(6,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}

						if (nam=="BtnLigna")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
							mana.		EmpresaRay(7);
			
							//				StartCoroutine(				mana.				Empresa	(7,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}

						if (nam=="BtnControlEng")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
							mana.		EmpresaRay(8);
			
			
							//StartCoroutine(				mana.				Empresa	(8,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnAdministracion")
						{
							Presionado.IsHolding=false;
							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			
							//					Nombre.text="caso1";
							mana.		EmpresaRay(5);
	

						}


						
					}else  if(activo==false){
	        	          
						if(hitObject.transform.name=="canvasInformacion"){
							penderPanel=hitObject.transform.gameObject;
							penderPanel.SetActive(false);	
							//penderPANELsECONDS.SetActive(false);
							//activo=false;
						}
					}
				}
				else
				{
					Destroy(touchLine.gameObject,1f);
					StartCoroutine(DestroyLineSmoothly(touchLine));
				}
				//		}//fin touch began 
				
			}
			
			
			
			
			
		}
    	
        
		}
    
		Ray viewRay =arCamera.ViewportPointToRay(new Vector3(0.5f,0.5f,0));
        
		//Draw ray
		viewLine.SetPosition(0,viewRay.origin - new Vector3(0,0.1f,0));
		viewLine.SetPosition(1,viewRay.direction*10f);

		RaycastHit hit;
		if (Physics.Raycast(viewRay, out hit)) {
			hit.transform.localScale *= 0.99f;
    
	}//fin Update
	
	
	
}
		
	
	LineRenderer CreateLine(string name, Color lineColor)
	{
		GameObject go = new GameObject(name);
		LineRenderer line = go.AddComponent<LineRenderer>();
		line.material = lineMaterial;
		line.positionCount = 2;
		line.startWidth = 0.01f;
		line.endWidth = 0.01f;
		line.colorGradient.mode = GradientMode.Fixed;
		line.startColor = lineColor;
		line.endColor = lineColor;
		return line;

	}
	IEnumerator DestroyLineSmoothly(LineRenderer line)
	{
		while(line.startColor.a >0) {
            
			Color color = line.startColor - new Color(0,0,0,Time.deltaTime * 0.5f);
			line.startColor=color;
			line.endColor=color;
			Debug.Log(line.startColor);
			yield return 0;
		}
		Destroy(line.gameObject);
	}
	
	
}
