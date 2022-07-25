using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Manager : MonoBehaviour
{
	public GameObject Inicio,Mapa2D,infoEmpresa,infoEmpresa3D,ZonaFranca,Dispensario,PF,btnGiraGO;
	public Button btn2D,btn3D,btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,BtnAtras,BtnAtrasMap,BtnAtras3d,
		btnleyd1,btnleyd2,btnleyd3,btnleyd4,btnleyd5,btnleyd6,btnleyd7,btnleyd8,btnNom2D,btnNom3D;
    
	public UI_HoldButton gira;
	
	
	
	public Sprite [] FotoEmpresa;
	
	public Image Foto,Foto1,Foto2,Foto3D;
	
	public TMP_Text Descripcion,nomedi,numven,DescripEmp3D;
    
    
	/// <Modelos>
	
	public Transform objeto;
	public Button BtnDispensario;
	
	
	/// </Modelos>
	private float initialDistance,initialDistance1;
	private Vector3 initialScale;
	private Vector2 posfinal;

	//	private Vector3 scaleChange, positionChange;

  
	public Button flechaD,FlechaI,BuscaPlano,Aurora,Ayuda;//giraModelo;
	public GameObject Contenedor,Tuto1,Tuto2,Tuto3,Reubica,Atras3D,BtnsLeyenda,Marco3d;
	int tuto=0;
	public int ventana;
	bool tutoestado=true;
	public GameObject[] btns3D;
	
	UI_HoldButton Presionado;

	public GameObject raycast,VentanaTutorial,groundPlane;
    
	public Button siguientBTN;
	
	int omi=1;
    
    void Start()
	{
		
		gira.enabled=true;
		Presionado=GameObject.FindGameObjectWithTag("TagPresionado").GetComponent<UI_HoldButton>();
		ventana=1;
	    Inicio.SetActive(true);
	    Mapa2D.SetActive(false);
	    infoEmpresa.SetActive(false);
	    ZonaFranca.SetActive(false);
		BuscaPlano3d();
		infoEmpresa3D.SetActive(false);
	    // FondoDispensario.SetActive(false);
		//BtnAtras.onClick.AddListener(()=>StartCoroutine(back()));
		
		BtnAtras.onClick.AddListener(()=>back());
		
		
		btn1.onClick.AddListener(()=>Empresa(1,4));
		
		btnleyd1.onClick.AddListener(()=> Empresa(1,4));
	    
		btn2.onClick.AddListener(()=> Empresa(2,4));
		btnleyd2.onClick.AddListener(()=>  Empresa(2,4));
	    
		btn3.onClick.AddListener(()=>Empresa(3,4));
		btnleyd3.onClick.AddListener(()=>Empresa(3,4));
	    
		btn4.onClick.AddListener(()=> Empresa(4,4));
		btnleyd4.onClick.AddListener(()=> Empresa(4,4));
	    
		btn5.onClick.AddListener(()=> Empresa(5,4));
		btnleyd5.onClick.AddListener(()=> Empresa(5,4));
	    
		btn6.onClick.AddListener(()=> Empresa(6,4));
		btnleyd6.onClick.AddListener(()=> Empresa(6,4));
	    
		btn7.onClick.AddListener(()=> Empresa(7,4));
		btnleyd7.onClick.AddListener(()=> Empresa(7,4));
	    
	    
		btn8.onClick.AddListener(()=> Empresa(8,4));
		btnleyd8.onClick.AddListener(()=> Empresa(8,4));
	    
		
		
		
		
		//	btn2D.onClick.AddListener(()=> StartCoroutine( IRmapa2D()));
		btn2D.onClick.AddListener(()=>  IRmapa2D());
		//btnNom2D.onClick.AddListener(()=>StartCoroutine( IRmapa2D()));
		btnNom2D.onClick.AddListener(()=>IRmapa2D());
	    //  BtnDispensario.onClick.AddListener(()=> InfoDis());
	    
	    
	    
		//	btn3D.onClick.AddListener(() =>StartCoroutine( IRmapa3D()));
		btn3D.onClick.AddListener(() => IRmapa3D());
	     btnNom3D.onClick.AddListener(()=> IRmapa3D());
		//btnNom3D.onClick.AddListener(() => StartCoroutine (IRmapa3D()));
		//	BtnAtras3d.onClick.AddListener(()=>StartCoroutine(Iniciox3D()));
		//	BtnAtras3d.onClick.AddListener(()=>Iniciox3D());
	    //  btn2D.onClick.AddListener(()=> Categoria(1));
        
	  
			flechaD.onClick.AddListener(()=>EmpresaRay(4));
		
		FlechaI.onClick.AddListener(()=>CerrarEmpresaRay());
	    BuscaPlano.onClick.AddListener(()=>BuscaPlano3d());
	   
	   
		
	   
		/*
	    
		btntuto1.onClick.AddListener(()=> omitirIntro(1));
		btntuto2.onClick.AddListener(()=> omitirIntro(2));
		btntuto3.onClick.AddListener(()=> omitirIntro(3));
	
		*/
		
		siguientBTN.onClick.AddListener(()=>omitirIntro(omi));
		
	}// fin start
    
    
	void omitirIntro(int num)
	{
		VentanaTutorial.SetActive(true);
		raycast.SetActive(false);
		raycast.GetComponent<arRaycaster>().enabled=false;
		btns3D[0].SetActive(false);
		btns3D[1].SetActive(false);
		btns3D[1].SetActive(false);
		PF.SetActive(false);
		groundPlane.SetActive(false);
		switch (num)
		{
		
		case 1:
			Tuto1.SetActive(true);
			Tuto2.SetActive(false);
			Tuto3.SetActive(false);
			
			Debug.Log("Omi es:"+omi);
			break;
		
		
		case 2:
			Tuto2.SetActive(true);
			Tuto1.SetActive(false);
			Tuto3.SetActive(false);
			
			Debug.Log("Omi es:"+omi);
			break;
		
		case 3:
			Tuto3.SetActive(true);
			Tuto2.SetActive(false);
			Tuto1.SetActive(false);
			siguientBTN.onClick.AddListener(()=>IRmapa3D());
			Debug.Log("Omi es:"+omi);
			break;
		
		}
		
		omi=num+1;
		
		if (omi>3)
		{
			omi=1;
			
		}
		
		//IRmapa3D();
		
		
	}
    
    
    
	void BuscaPlano3d()
	{
		PF.SetActive(true);
		Marco3d.SetActive(true);
	}
    
    
	public	void Iniciox3D()
	{
		ventana=1;
		int y=1630;
		float sec=0.0000000001f;
		
		infoEmpresa.SetActive(false);
		Mapa2D.SetActive(false);
		Inicio.SetActive(true);
		
		PF.SetActive(false);
		groundPlane.SetActive(false);
		
		ZonaFranca.SetActive(false);
		gira.enabled=true;
		
	}//Fin IRmapa2D
    
    
	


	public	void Volver2D()
	{
		
		
		ventana=2;
		Inicio.SetActive(false);
		ZonaFranca.SetActive(false);
		infoEmpresa.SetActive(false);
		Mapa2D.SetActive(true);
		BtnsLeyenda.SetActive(false);
		
		BtnsLeyenda.SetActive(true);
		
	}//Fin IRmapa2D



	public	void IRmapa2D()
	{
		int y=1630;
		float sec=0.0000000001f;
		
		ventana=2;
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(false);
		//Mapa2D.transform.position = new	Vector3(966,y,0f);
		Mapa2D.SetActive(true);
		
		
		ZonaFranca.SetActive(false);
		Inicio.SetActive(false);
		
	}//Fin IRmapa2D
	
	
	public void back()
	{
		ventana=1;
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(false);
		Inicio.SetActive(true);
		
		
		Mapa2D.SetActive(false);	
		
	}// fin back

	
	
	
	
	
	public void IRmapa3D()
	{
		ventana=3;
		raycast.SetActive(true);
		PF.SetActive(true);
		groundPlane.SetActive(true);
		raycast.GetComponent<arRaycaster>().enabled=true;
		btns3D[0].SetActive(true);
		btns3D[1].SetActive(true);
		btns3D[2].SetActive(true);
		VentanaTutorial.SetActive(false);
		Presionado.IsHolding=false;
		Mapa2D.SetActive(false);
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(true);
		Ayuda.onClick.AddListener(()=> omitirIntro(1));
		
		BtnAtras3d.onClick.AddListener(()=>Iniciox3D());
		objeto=Dispensario.transform;
		
		Inicio.SetActive(false);
		
		
		gira.enabled=true;
		
	}//Fin IRmapa3D



	public	void Empresa(int emp,int ven)
	{
		gira.enabled=false;
		//StopCoroutine(Empresa(emp,ven));
		ventana=ven;
		Inicio.SetActive(false);
		
		infoEmpresa.SetActive(true);
		ZonaFranca.SetActive(false);
		//	BtnAtras3d.onClick.AddListener(()=>StartCoroutine(Iniciox3D()));
		Presionado.IsHolding=false;
		
		numven.text=ventana.ToString();
		if (ven==4)
		{
			//		BtnAtrasMap.onClick.AddListener(()=> StartCoroutine(Volver2D()));	
			BtnAtrasMap.onClick.AddListener(()=> Volver2D());
		}
		if (ven==5)
		{
			//	BtnAtrasMap.onClick.AddListener(()=> StartCoroutine(Volver3D()));	
			BtnAtrasMap.onClick.AddListener(()=> Volver3D());	
		}
		
		
		switch (emp)
		{
		
		case 1:
			Foto.sprite= FotoEmpresa[0];
			Foto1.sprite= FotoEmpresa[16];
			Foto2.sprite= FotoEmpresa[17];
			Descripcion.text="El comedor es el área donde todos los empleados, pueden disgustar de sus alimentos"+
				" en sus tiempos de recesos, la misma cuenta con una cocina donde se venden distintos platos a la"+
				" hora del desayuno y almuerzo.";
			break;
			
		case 2:
			Foto.sprite= FotoEmpresa[1];
			Foto1.sprite= FotoEmpresa[18];
			Foto2.sprite= FotoEmpresa[19];
			Descripcion.text="El dispensario médico está diseñado para brindarte una oportuna atención de salud."+
				"Se atienden casos que no requieran de hospitalización, se brindan primeros auxilios y se efectúan"+
				"recetarios de medicamentos, en casos que lo ameriten.";
			break;
			
		case 3:
			Foto.sprite= FotoEmpresa[2];
			Foto1.sprite= FotoEmpresa[10];
			Foto2.sprite= FotoEmpresa[11];
			Descripcion.text="En t-eco Group, estamos sentando las bases para construir un mejor futuro con"+
				" proyectos que sean socialmente responsables, con metas medibles, en condiciones ambientalmente sostenibles,"+
				" tecnológicamente avanzadas, económicamente viables y absolutamente realizables.";
			break;
			
		case 4:
			Foto.sprite= FotoEmpresa[3];
			Foto1.sprite= FotoEmpresa[8];
			Foto2.sprite= FotoEmpresa[9];
			Descripcion.text="La Aurora, la compañía tabaquera más antigua de República Dominicana líder en el"+
				" mercado de tabaco dominicano y con presencia en más de sesenta países– ha apostado por un proyecto"+
				" innovador y único en el mundo: La Aurora Cigar World. Un concepto cuyo objetivo es formar a"+
				" auténticos expertos en Cigarros Premium. Por ello, la Aurora Cigar World ve materializada su"+
				" estrategia en dos pilares fundamentales: La Aurora Cigar Institute y La Aurora Factory Tour. ";
			break;
			
		case 5:
			Foto.sprite= FotoEmpresa[4];
			Foto1.sprite= FotoEmpresa[20];
			Foto2.sprite= FotoEmpresa[21];
			Descripcion.text="La oficina principal también puede servir como hogar para maquinaria de oficina. Los dispositivos"+
				" comunes que se encuentran en la oficina incluyen copiadoras, máquinas de fax, teléfonos multilínea, máquinas de correo"+
				" y báscula para correo y computadoras de oficina.";
			break;
		
		case 6:
			Foto.sprite= FotoEmpresa[5];
			Foto1.sprite= FotoEmpresa[12];
			Foto2.sprite= FotoEmpresa[13];
			Descripcion.text="Empresa encargada  de importación, exportación, fabricación Y comercialización de productos textiles y "+
				"prendas de vestir. Tanto productos como pantalones, batas de laboratorios, mascarillas y "+
				"todo tipos e Textil que el cliente desee ordenar.";
			break;
		
		case 7:
			Foto.sprite= FotoEmpresa[6];
			Foto1.sprite= FotoEmpresa[6];
			Foto2.sprite= FotoEmpresa[6];
			Descripcion.text="A.J.B Ligna Group, es una empresa encargada de la manufacturación de cajas para"+
				" cigarros, esta empresa su gestor es Ana Cristina Martínez Rodríguez y el titular Jose Augusto Arias Corominas.";
			break;
		
		case 8:
			Foto.sprite= FotoEmpresa[7];
			Foto1.sprite= FotoEmpresa[14];
			Foto2.sprite= FotoEmpresa[15];
			Descripcion.text="Control Engineering cuenta con más de dos décadas brindando soluciones de"+
				" automatización de procesos industriales a sus clientes, con un trato enteramente profesional."+
				" Nuestra filosofía empresarial busca servir con responsabilidad, ética, calidad e innovación, con "+
				"el objetivo de ofrecer a las industrias y clientes relacionados el soporte necesario para la"+
				" optimización de sus procesos.";
			break;
		
		
		}// fin switch
		
		
		Mapa2D.SetActive(false);	
		
		
		
		
	}//fin empresa


	private void Update()
	{
		
		Debug.Log(ZonaFranca.transform.position);
			
			
		if (Input.touchCount ==1)
		{
			//variable para el dedo que toca la pantalla
			Touch dedo = Input.GetTouch(0);
			
			
			Vector2 origen= new Vector2(0,0);
			
			
			
			
			// si ese dedo se movio
			if (dedo.phase == TouchPhase.Moved)
			{
				
				initialDistance1= Vector2.Distance(origen,dedo.position);
				
				
				
				
				if(Mathf.Approximately(initialDistance1,1100))
				{
					return;// do nothing if it can be ignored where initial distance is very close to zero

				}
				
				
				// roto el objeto en funcion a la posicion en X en la que se movio
				objeto.transform.Rotate(0f,dedo.deltaPosition.x,0f);
				
				
			}//si el dedo es movido
			
			else
			{
			
			}
			
			
			
		
		}// si toca con un dedo
			
			
			
			
			
			
			
			if(Input.touchCount ==2)
			{
				var touchZero= Input.GetTouch(0);
				var touchOne= Input.GetTouch(1);
				
				infoEmpresa.SetActive(false);

				//if any one of touchZero or touchOne is cancelled or maybe ended then nothing
				if(touchZero.phase == TouchPhase.Ended || touchZero.phase == TouchPhase.Canceled||
					touchOne.phase == TouchPhase.Ended || touchOne.phase == TouchPhase.Canceled)
				{
					raycast.GetComponent<arRaycaster>().enabled=true;
					return; //basically do nothing

				}

				if(touchZero.phase == TouchPhase.Began ||touchOne.phase == TouchPhase.Began)
				{
					raycast.GetComponent<arRaycaster>().enabled=false;
					initialDistance= Vector2.Distance(touchZero.position,touchOne.position);
					initialScale= objeto.transform.localScale;
					Debug.Log("Distancia Inicial:" + initialDistance);
				}
				else // if touch is moved
				{
					var currentDistance= Vector2.Distance(touchZero.position,touchOne.position);

					// if accidentally touched or pinch movement is very small

					if(Mathf.Approximately(initialDistance,0))
					{
						return;// do nothing if it can be ignored where initial distance is very close to zero

					}

					var factor= currentDistance / initialDistance;
					objeto.transform.localScale = initialScale * factor;



				}
			
		
		}
		// // // // // // // // // // // // // // // // / //
		
		Vector3 scala= objeto.transform.localScale;
		
		if (scala.x>7 || scala.y>7 || scala.z>7)
		{
			objeto.transform.localScale= new Vector3(7,7,7);
		}
	
		if (scala.x<1 || scala.y<1 || scala.z<1)
		{
			objeto.transform.localScale= new Vector3(1,1,1);
		}
		
	
	}// fin Update


	public void GirarModelo()
	{
		gira.enabled=true;
		objeto.transform.Rotate(0f,1f,0f);
	}// fin Girar Modelo

	
	
	

	public	void EmpresaRay(int emp)
	{
		
		raycast.SetActive(false);
		raycast.GetComponent<arRaycaster>().enabled=false;
		
		for (int i = 0; i < 3; i++) {
			btns3D[i].SetActive(false);
		}
		
		
		
		infoEmpresa3D.SetActive(true);
		Debug.Log(Contenedor.transform.position);
		Contenedor.transform.position = new	Vector3(-200,550,0f);
		
		
		
		switch (emp)
		{
		
		case 1:
			Foto3D.sprite= FotoEmpresa[0];
			
			DescripEmp3D.text="El comedor es el área donde todos los empleados, pueden disgustar de sus alimentos"+
				" en sus tiempos de recesos, la misma cuenta con una cocina donde se venden distintos platos a la"+
				" hora del desayuno y almuerzo.";
			break;
			
		case 2:
			Foto3D.sprite= FotoEmpresa[1];
			
			DescripEmp3D.text="El dispensario médico está diseñado para brindarte una oportuna atención de salud."+
				"Se atienden casos que no requieran de hospitalización, se brindan primeros auxilios y se efectúan"+
				"recetarios de medicamentos, en casos que lo ameriten.";
			break;
			
		case 3:
			Foto3D.sprite= FotoEmpresa[2];
			
			DescripEmp3D.text="En t-eco Group, estamos sentando las bases para construir un mejor futuro con"+
				" proyectos que sean socialmente responsables, con metas medibles, en condiciones ambientalmente sostenibles,"+
				" tecnológicamente avanzadas, económicamente viables y absolutamente realizables.";
			break;
			
		case 4:
			Foto3D.sprite= FotoEmpresa[3];
			
			DescripEmp3D.text="La Aurora, la compañía tabaquera más antigua de República Dominicana líder en el"+
				" mercado de tabaco dominicano y con presencia en más de sesenta países";
			break;
			
		case 5:
			Foto3D.sprite= FotoEmpresa[4];
			
			DescripEmp3D.text="La oficina principal también puede servir como hogar para maquinaria de oficina. Los dispositivos"+
				" comunes que se encuentran en la oficina incluyen copiadoras, máquinas de fax, teléfonos multilínea, máquinas de correo"+
				" y báscula para correo y computadoras de oficina.";
			break;
		
		case 6:
			Foto3D.sprite= FotoEmpresa[5];
			
			DescripEmp3D.text="Empresa encargada  de importación, exportación, fabricación Y comercialización de productos textiles y "+
				"prendas de vestir. Tanto productos como pantalones, batas de laboratorios, mascarillas y "+
				"todo tipos e Textil que el cliente desee ordenar.";
			break;
		
		case 7:
			Foto3D.sprite= FotoEmpresa[6];
			
			DescripEmp3D.text="A.J.B Ligna Group, es una empresa encargada de la manufacturación de cajas para"+
				" cigarros, esta empresa su gestor es Ana Cristina Martínez Rodríguez y el titular Jose Augusto Arias Corominas.";
			break;
		
		case 8:
			Foto3D.sprite= FotoEmpresa[7];
			
			DescripEmp3D.text="Control Engineering cuenta con más de dos décadas brindando soluciones de"+
				" automatización de procesos industriales a sus clientes, con un trato enteramente profesional."+
				" Nuestra filosofía empresarial busca servir con responsabilidad, ética, calidad e innovación, con "+
				"el objetivo de ofrecer a las industrias y clientes relacionados el soporte necesario para la"+
				" optimización de sus procesos.";
			break;
		
		
		}// fin switch
		
	}//Fin empresa Ray

	public	void CerrarEmpresaRay()
	{
		infoEmpresa3D.SetActive(false);
		raycast.SetActive(true);
		raycast.GetComponent<arRaycaster>().enabled=true;

		Debug.Log(Contenedor.transform.position);
		Contenedor.transform.position = new	Vector3(3000,1600,0f);
		
		
		
		for (int i = 0; i < 3; i++) {
			btns3D[i].SetActive(true);
		}
		
	
	}
	
	
	public	void Volver3D()
	{
		//	Reubica.SetActive(true);
		//	Atras3D.SetActive(true);
		Presionado.IsHolding=false;
		Mapa2D.SetActive(false);
		Inicio.SetActive(false);
		
		//	BtnAtras3d.onClick.AddListener(()=>StartCoroutine(Iniciox3D()));
		BtnAtras3d.onClick.AddListener(()=>Iniciox3D());
		/*	
		
		int x=1180;
		float sec=0.00000001f;
		
		for (int i = x; i <= 4000;i+=100) {
			infoEmpresa.transform.position = new	Vector3(i,540,0);
			yield return new WaitForSeconds(sec);
			Debug.Log(infoEmpresa.transform.position);
			
		}
		infoEmpresa.transform.position = new	Vector3(4000,540,0);
		
			
		ZonaFranca.transform.position = new	Vector3(173.21f,469.32f,-1554);
		*/
		
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(true);
		
		
	} 
	
	
	
}// fin de public 
