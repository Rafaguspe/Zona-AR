using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arRaycaster : MonoBehaviour {
    
    

	public GameObject penderPanel;
	public GameObject objetoIns;
	bool activo=false;
	
	
	
	//	[SerializeField] float RotationSpeed = 2f;
	bool dragging = false;
	Rigidbody rb; 
	
	
	
	Manager mana;
	UI_HoldButton Presionado;
	
	
	
	
	[SerializeField]
	[Tooltip("Camera for raycast, default is Camera which tagged as MainCamera")]
	private Camera arCamera;
	[SerializeField]
	[Tooltip("Material of Drawn Raycast line")]
	private Material lineMaterial;
	private LineRenderer viewLine;
	private LineRenderer touchLine;
	
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
	
	void Update() {
		
		if(Input.GetMouseButtonUp (0))
		{
			dragging = false; 
		}
		
		
		
		// Touch raycast
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch(0);
			var touchPositon = touch.position;
			Ray touchRay = arCamera.ScreenPointToRay(touchPositon);
			switch (touch.phase)
			{
			case TouchPhase.Began :
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
			if (touch.phase == TouchPhase.Began) {

				RaycastHit hitObject;
				if (Physics.Raycast(touchRay,out hitObject)) {
					
					string nam;
					nam=hitObject.transform.name;
					
					
					//hitObject.transform.localScale *= 1.2f;
					if(activo==false&&nam=="BtnAurora"||activo==false&&nam=="BtnAurora1"||
						activo==false&&nam=="BtnAurora2"||activo==false&&nam=="BtnAurora3"||
						activo==false&&nam=="BtnAurora4"||activo==false&&nam=="BtnComedor"||
						activo==false&&nam=="BtnDispensario"||activo==false&&nam=="BtnT-eco"||
						activo==false&&nam=="BtnAmle"||activo==false&&nam=="BtnLigna"||
						activo==false&&nam=="BtnControlEng"||activo==false&&nam=="BtnAdministracion"
						||activo==false&&nam=="Cube"){
							
						//penderPanel=hitObject.transform.GetChild(1).gameObject;
						//			penderPanel.SetActive(true);
						
						//penderPANELsECONDS=hitObject.transform.GetChild(2).gameObject;
						//penderPANELsECONDS.SetActive(true);
						
						if (nam=="BtnAurora"||nam=="BtnAurora1"||nam=="BtnAurora2"||nam=="BtnAurora3"||nam=="BtnAurora4")
						{


							Presionado.IsHolding=false;
							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			
							mana.Empresa	(4,5);
							//				StartCoroutine(mana.Empresa	(4,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=> StartCoroutine(mana.Volver3D()));

						}

						if (nam=="BtnComedor")
						{
							Presionado.IsHolding=false;
							//						Reubica.SetActive(false);
							//						Atras3D.SetActive(false);
			
							mana.				Empresa	(1,5);
							//				StartCoroutine(mana.				Empresa	(1,5));
							//						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnDispensario")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			
							mana.				Empresa	(2,5);
							//				StartCoroutine(				mana.				Empresa	(2,5));
							//						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnT-eco")
						{
							Presionado.IsHolding=false;
							//						Reubica.SetActive(false);
							//						Atras3D.SetActive(false);
			
							//				Nombre.text="caso1";
							mana.				Empresa	(3,5);
							//				StartCoroutine(				mana.				Empresa	(3,5));
							//						mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnAmle")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			
							//					Nombre.text="caso1";
							mana.				Empresa	(6,5);
							//				StartCoroutine(				mana.				Empresa	(6,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}

						if (nam=="BtnLigna")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
							mana.				Empresa	(7,5);
			
							//				StartCoroutine(				mana.				Empresa	(7,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}

						if (nam=="BtnControlEng")
						{
							Presionado.IsHolding=false;

							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
							mana.				Empresa	(8,5);
			
			
							//StartCoroutine(				mana.				Empresa	(8,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=>StartCoroutine(mana.Volver3D()));
						}


						if (nam=="BtnAdministracion")
						{
							Presionado.IsHolding=false;
							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			
							//					Nombre.text="caso1";
							mana.					Empresa	(5,5);
	

							//				StartCoroutine(				mana.					Empresa	(5,5));
							//					mana.BtnAtrasMap.onClick.AddListener(()=> StartCoroutine(mana.Volver3D()));
						}

						
						
						//			objetoIns=hitObject.transform.GetChild(0).gameObject;
						//			rb=objetoIns.GetComponent<Rigidbody>();
						
						
						
						}else  if(activo==false){
	        	          
							if(hitObject.transform.name=="canvasInformacion"){
								penderPanel=hitObject.transform.gameObject;
								penderPanel.SetActive(false);	
								//penderPANELsECONDS.SetActive(false);
								//activo=false;
							}
						}
				}
			}
		
			
			//float X = Input.GetAxis ("Mouse X") * RotationSpeed * Time.fixedDeltaTime;
			//float y = Input.GetAxis ("Mouse Y") * RotationSpeed * Time.fixedDeltaTime;
			
		
			
			//	rb.AddTorque (Vector3.down*X);
			//		rb.AddTorque (Vector3.right*y);
	
			
	
	
			
		}


		// Viewpoint raycast
		Ray viewRay =arCamera.ViewportPointToRay(new Vector3(0.5f,0.5f,0));
        
		//Draw ray
		viewLine.SetPosition(0,viewRay.origin - new Vector3(0,0.1f,0));
		viewLine.SetPosition(1,viewRay.direction*10f);

		RaycastHit hit;
		if (Physics.Raycast(viewRay, out hit)) {
			hit.transform.localScale *= 0.99f;
            
		}
	}
	
	
	//void FixedUpdate()
	//{
	//	if(dragging)
	//	{
	//		float X = Input.GetAxis ("Mouse X") * RotationSpeed * Time.fixedDeltaTime;
	//		float y = Input.GetAxis ("Mouse Y") * RotationSpeed * Time.fixedDeltaTime;
	//		rb.AddTorque (Vector3.down*X);
	//		rb.AddTorque (Vector3.right*y);
			
	//	}
	//}
	
	
	
	
	
	LineRenderer CreateLine(string name, Color lineColor)
	{
		GameObject go = new GameObject(name);
		LineRenderer line = go.AddComponent<LineRenderer>();
		line.material = lineMaterial;
		line.positionCount=2;
		line.startWidth=0.01f;
		line.endWidth=0.01f;
		line.colorGradient.mode = GradientMode.Fixed;
		line.startColor=lineColor;
		line.endColor=lineColor;
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
