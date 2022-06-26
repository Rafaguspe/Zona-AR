using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Manager : MonoBehaviour
{
	public GameObject Inicio,Mapa2D,infoEmpresa,ZonaFranca,Dispensario,PF;
	public Button btn2D,btn3D,btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,BtnAtras,BtnAtrasMap,BtnAtras3d,
		btnleyd1,btnleyd2,btnleyd3,btnleyd4,btnleyd5,btnleyd6,btnleyd7,btnleyd8,btnNom2D,btnNom3D;
    
	
	
	
	
	public Sprite [] FotoEmpresa;
	
	public Image Foto;
	
	public TMP_Text Descripcion;
    
    
	/// <Modelos>
	
	public Transform objeto;
	public Button BtnDispensario;
	
	
	/// </Modelos>
    
  
  
	public Button flechaD,FlechaI,BuscaPlano,Aurora;
	public GameObject Contenedor,Tuto1,Tuto2,Tuto3;

    
    
    void Start()
    {
	    Inicio.SetActive(true);
	    Mapa2D.SetActive(false);
	    infoEmpresa.SetActive(false);
	    ZonaFranca.SetActive(false);
	    PF.SetActive(true);
	    // FondoDispensario.SetActive(false);
	    BtnAtras.onClick.AddListener(()=> back());
	    
	    btn1.onClick.AddListener(()=> Empresa(1));
	    btnleyd1.onClick.AddListener(()=> Empresa(1));
	    
	    btn2.onClick.AddListener(()=> Empresa(2));
	    btnleyd2.onClick.AddListener(()=> Empresa(2));
	    
	    btn3.onClick.AddListener(()=> Empresa(3));
	    btnleyd3.onClick.AddListener(()=> Empresa(3));
	    
	    btn4.onClick.AddListener(()=> Empresa(4));
	    btnleyd4.onClick.AddListener(()=> Empresa(4));
	    
	    btn5.onClick.AddListener(()=> Empresa(5));
	    btnleyd5.onClick.AddListener(()=> Empresa(5));
	    
	    btn6.onClick.AddListener(()=> Empresa(6));
	    btnleyd6.onClick.AddListener(()=> Empresa(6));
	    
	    btn7.onClick.AddListener(()=> Empresa(7));
	    btnleyd7.onClick.AddListener(()=> Empresa(7));
	    
	    
	    btn8.onClick.AddListener(()=> Empresa(8));
	    btnleyd8.onClick.AddListener(()=> Empresa(8));
	    
	    btn2D.onClick.AddListener(()=> IRmapa2D());
	    btnNom2D.onClick.AddListener(()=> IRmapa2D());
	    //  BtnDispensario.onClick.AddListener(()=> InfoDis());
	    
	    
	    
	    btn3D.onClick.AddListener(() => StartCoroutine(IRmapa3D()));
	    // btnNom3D.onClick.AddListener(()=> IRmapa3D());
	    btnNom3D.onClick.AddListener(() => StartCoroutine(IRmapa3D()));
	    BtnAtras3d.onClick.AddListener(()=> Start());
	    //  btn2D.onClick.AddListener(()=> Categoria(1));
        
	  
	    flechaD.onClick.AddListener(()=>MoverD());
	    FlechaI.onClick.AddListener(()=>MoverI());
	    BuscaPlano.onClick.AddListener(()=>PF.SetActive(true));
	    Aurora.onClick.AddListener(()=>Inicio.SetActive(true));
	    
	    
    }



 void IRmapa2D()
	{
		Inicio.SetActive(false);
		Mapa2D.SetActive(true);
		infoEmpresa.SetActive(false);
		
		
		
		
	}//Fin IRmapa2D
	
	
	
private IEnumerator IRmapa3D()
	{
		Inicio.SetActive(false);
		Mapa2D.SetActive(false);
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(true);
		objeto=Dispensario.transform;
		
		Tuto1.SetActive(true);
		yield return new WaitForSeconds(3);
		Tuto1.SetActive(false);
		Tuto2.SetActive(true);
		yield return new WaitForSeconds(5);
		Tuto2.SetActive(false);
		Tuto3.SetActive(true);
		yield return new WaitForSeconds(10);
		Tuto3.SetActive(false);
		
		
	}//Fin IRmapa3D

	void back()
	{
		Mapa2D.SetActive(false);	
		infoEmpresa.SetActive(false);
		Inicio.SetActive(true);
	}// fin back


	void Empresa(int emp)
	{
		Mapa2D.SetActive(false);	
		infoEmpresa.SetActive(true);
		BtnAtrasMap.onClick.AddListener(()=> IRmapa2D());
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


	private void Update()
	{
		
		
		// si hay dos dedo pulsando la pantalla
		
		if (Input.touchCount ==2)
		{
			//variable para el dedo que toca la pantalla
			Touch dedo = Input.GetTouch(1);
			
			
			// si ese dedo se movio
			if (dedo.phase == TouchPhase.Moved)
			{
				// roto el objeto en funcion a la posicion en X en la que se movio
				objeto.transform.Rotate(0f,dedo.deltaPosition.x,0f);
				
				
			}
		
		}
		// // // // // // // // // // // // // // // // / //
		
		
		// si hay dos dedo pulsando la pantalla
		
		if (Input.touchCount ==1)
		{
			//variable para el dedo que toca la pantalla
			Touch dedo = Input.GetTouch(0);
			
			
			// si ese dedo se movio
			//	if (dedo.phase == TouchPhase.Began)
			//	{
				//		Ray ray= arCamera.ScreenPointToRay(dedo.position);
			//	}
			
		}
		
		
		
		
		
		
	}// fin Update


	void GirarModelo()
	{
		objeto.transform.Rotate(0f,10f,0f);
	}// fin Girar Modelo

	

	void MoverD()
	{
		Debug.Log(Contenedor.transform.position);
		Contenedor.transform.position = new	Vector3(-1000,363,0f);
	}

	void MoverI()
	{
		Debug.Log(Contenedor.transform.position);
		Contenedor.transform.position = new	Vector3(2500,363,0f);
	}
   
}// fin de public 
