using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class arRaycaster : MonoBehaviour {
    
    
	public TMP_Text Nombre;
	public GameObject penderPanel,Reubica,Atras3D;
	//public GameObject penderPANELsECONDS;
	public GameObject objetoIns;
	bool activo=false;
	
	
	
	//[SerializeField] float RotationSpeed = 2f;
	//bool dragging = false;
	Rigidbody rb; 
	
	//	public GameObject Inicio,Mapa2D,infoEmpresa,ZonaFranca,Dispensario,PF;
	//	public Sprite [] FotoEmpresa;
	
	//	public Image Foto;
	
	//	public TMP_Text Descripcion;
	
	
	//	public Button BtnAtrasMap;
	
	
	
	[SerializeField]
	[Tooltip("Camera for raycast, default is Camera which tagged as MainCamera")]
	private Camera arCamera;
	[SerializeField]
	[Tooltip("Material of Drawn Raycast line")]
	private Material lineMaterial;
	private LineRenderer viewLine;
	private LineRenderer touchLine;
	
	
	Manager mana;
	
	
	void Start()
	{
		if(arCamera == null)    arCamera = Camera.main;
		mana=GameObject.FindGameObjectWithTag("TagMana").GetComponent<Manager>();
		//viewLine = CreateLine("ViewLine", Color.red);
       
	}
	
	//void OnMouseDrag()
	//	{
	//		dragging = true;
	//	}
	
	void Update() {
		
		//	if(Input.GetMouseButtonUp (0))
		//	{
		//		dragging = false; 
		//	}
		
		
		
		// Touch raycast
		if (Input.touchCount == 1) {
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
					
					Nombre.text=nam;
					
					//hitObject.transform.localScale *= 1.2f;
					if(activo==false&&nam=="BtnAurora"||activo==false&&nam=="BtnAurora1"||
						activo==false&&nam=="BtnAurora2"||activo==false&&nam=="BtnAurora3"||
						activo==false&&nam=="BtnAurora4"||activo==false&&nam=="BtnComedor"||
						activo==false&&nam=="BtnDispensario"||activo==false&&nam=="BtnT-eco"||
						activo==false&&nam=="BtnAmle"||activo==false&&nam=="BtnLigna"||
						activo==false&&nam=="BtnControlEng"||activo==false&&nam=="BtnAdministracion"){
					
						//penderPanel=hitObject.transform.GetChild(1).gameObject;
			
						//					penderPanel.SetActive(true);
			
						
						mana.ZonaFranca.SetActive(false);
						
						if (nam=="BtnAurora"||nam=="BtnAurora1"||nam=="BtnAurora2"||nam=="BtnAurora3")
						{
										
			
							mana.Empresa	(4,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
			
						}
			
						if (nam=="BtnComedor")
						{
										
		
							mana.				Empresa	(1,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
						}
			
			
						if (nam=="BtnDispensario")
						{
										
							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			mana.				Empresa	(2,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
						}
			
			
						if (nam=="BtnT-eco")
						{
										
							//						Reubica.SetActive(false);
							//						Atras3D.SetActive(false);
			mana.				Empresa	(3,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
						}
			
			
						if (nam=="BtnAmle")
						{
										
							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			mana.				Empresa	(6,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
						}
						
						if (nam=="BtnLigna")
						{
										
												//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
							mana.				Empresa	(7,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
						}
						
						if (nam=="BtnControlEng")
						{
										
							//					Reubica.SetActive(false);
							//					Atras3D.SetActive(false);
			mana.				Empresa	(8,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
						}
			
			
						if (nam=="BtnAdministracion")
						{
										
		
							mana.					Empresa	(5,5);
							mana.BtnAtrasMap.onClick.AddListener(()=>mana.Volver3D());
						}
			
			
						
						//penderPANELsECONDS=hitObject.transform.GetChild(2).gameObject;
						//penderPANELsECONDS.SetActive(true);
						
						
						
						//				objetoIns=hitObject.transform.GetChild(0).gameObject;
						//			rb=objetoIns.GetComponent<Rigidbody>();
						
						
						
					}
					/*
					else  if(activo==false){
	        	          
						if(hitObject.transform.name=="canvasInformacion"){
							penderPanel=hitObject.transform.gameObject;
							penderPanel.SetActive(false);	
							//penderPANELsECONDS.SetActive(false);
							//activo=false;
						}
					}
				}
				*/
			}
		
			
			//float X = Input.GetAxis ("Mouse X") * RotationSpeed * Time.fixedDeltaTime;
			//float y = Input.GetAxis ("Mouse Y") * RotationSpeed * Time.fixedDeltaTime;
			
				//	float X = Input.GetAxis ("Mouse X") * RotationSpeed * Time.deltaTime * Time.deltaTime;
				//	float y = Input.GetAxis ("Mouse Y") * RotationSpeed * Time.deltaTime* Time.deltaTime;
			
			
				//	rb.AddTorque (Vector3.down*X);
				//	rb.AddTorque (Vector3.right*y);
	
			
	
	
			
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
	
	/*
	
	void Volver3D()
	{
		//	Reubica.SetActive(true);
		//	Atras3D.SetActive(true);
		infoEmpresa.SetActive(false);
		Mapa2D.SetActive(false);
		Inicio.SetActive(false);
		ZonaFranca.SetActive(true);
		
	} 
	
	
	public	void Empresa(int emp)
	{
		ZonaFranca.SetActive(false);
		infoEmpresa.SetActive(true);
		BtnAtrasMap.onClick.AddListener(()=> Volver3D());
		switch (emp)
		{
		
		case 1:
			Foto.sprite= FotoEmpresa[0];
			Descripcion.text="El comedor es el área donde todos los empleados, pueden disgustar de sus alimentos"+
				" en sus tiempos de recesos, la misma cuenta con una cocina donde se venden distintos platos a la"+
				" hora del desayuno y almuerzo.";
			break;
			
		case 2:
			Foto.sprite= FotoEmpresa[1];
			Descripcion.text="El dispensario médico está diseñado para brindarte una oportuna atención de salud."+
				"Se atienden casos que no requieran de hospitalización, se brindan primeros auxilios y se efectúan"+
				"recetarios de medicamentos, en casos que lo ameriten.";
			break;
			
		case 3:
			Foto.sprite= FotoEmpresa[2];
			Descripcion.text="En t-eco Group, estamos sentando las bases para construir un mejor futuro con"+
				" proyectos que sean socialmente responsables, con metas medibles, en condiciones ambientalmente sostenibles,"+
				" tecnológicamente avanzadas, económicamente viables y absolutamente realizables.";
			break;
			
		case 4:
			Foto.sprite= FotoEmpresa[3];
			Descripcion.text="La Aurora, la compañía tabaquera más antigua de República Dominicana líder en el"+
				" mercado de tabaco dominicano y con presencia en más de sesenta países– ha apostado por un proyecto"+
				" innovador y único en el mundo: La Aurora Cigar World. Un concepto cuyo objetivo es formar a"+
				" auténticos expertos en Cigarros Premium. Por ello, la Aurora Cigar World ve materializada su"+
				" estrategia en dos pilares fundamentales: La Aurora Cigar Institute y La Aurora Factory Tour. ";
			break;
			
		case 5:
			Foto.sprite= FotoEmpresa[4];
			Descripcion.text="La oficina principal también puede servir como hogar para maquinaria de oficina. Los dispositivos"+
				" comunes que se encuentran en la oficina incluyen copiadoras, máquinas de fax, teléfonos multilínea, máquinas de correo"+
				" y báscula para correo y computadoras de oficina.";
			break;
		
		case 6:
			Foto.sprite= FotoEmpresa[5];
			Descripcion.text="Empresa encargada  de importación, exportación, fabricación Y comercialización de productos textiles y "+
				"prendas de vestir. Tanto productos como pantalones, batas de laboratorios, mascarillas y "+
				"todo tipos e Textil que el cliente desee ordenar.";
			break;
		
		case 7:
			Foto.sprite= FotoEmpresa[6];
			Descripcion.text="A.J.B Ligna Group, es una empresa encargada de la manufacturación de cajas para"+
				" cigarros, esta empresa su gestor es Ana Cristina Martínez Rodríguez y el titular Jose Augusto Arias Corominas.";
			break;
		
		case 8:
			Foto.sprite= FotoEmpresa[7];
			Descripcion.text="Control Engineering cuenta con más de dos décadas brindando soluciones de"+
				" automatización de procesos industriales a sus clientes, con un trato enteramente profesional."+
				" Nuestra filosofía empresarial busca servir con responsabilidad, ética, calidad e innovación, con "+
				"el objetivo de ofrecer a las industrias y clientes relacionados el soporte necesario para la"+
				" optimización de sus procesos.";
			break;
		
		
		}// fin switch
		
	}//fin empresa
	
	*/
}
