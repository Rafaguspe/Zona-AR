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
	
	public Image Foto,Foto1,Foto2;
	
	public TMP_Text Descripcion,nomedi;
    
    
	/// <Modelos>
	
	public Transform objeto;
	public Button BtnDispensario;
	
	
	/// </Modelos>
    
  
  
	public Button flechaD,FlechaI,BuscaPlano,Aurora;
	public GameObject Contenedor,Tuto1,Tuto2,Tuto3,Reubica,Atras3D;
	int tuto=0;
	public int ventana;
	
    
    
    void Start()
	{
		ventana=1;
	    Inicio.SetActive(true);
	    Mapa2D.SetActive(false);
	    infoEmpresa.SetActive(false);
	    ZonaFranca.SetActive(false);
	    PF.SetActive(true);
	    // FondoDispensario.SetActive(false);
		BtnAtras.onClick.AddListener(()=>StartCoroutine(back()));
	    
		btn1.onClick.AddListener(()=>StartCoroutine(Empresa(1,4)));
	    btnleyd1.onClick.AddListener(()=> StartCoroutine(Empresa(1,4)));
	    
		btn2.onClick.AddListener(()=>StartCoroutine( Empresa(2,4)));
	    btnleyd2.onClick.AddListener(()=> StartCoroutine( Empresa(2,4)));
	    
	    btn3.onClick.AddListener(()=>StartCoroutine( Empresa(3,4)));
	    btnleyd3.onClick.AddListener(()=>StartCoroutine( Empresa(3,4)));
	    
	    btn4.onClick.AddListener(()=>StartCoroutine( Empresa(4,4)));
	    btnleyd4.onClick.AddListener(()=>StartCoroutine( Empresa(4,4)));
	    
	    btn5.onClick.AddListener(()=>StartCoroutine( Empresa(5,4)));
	    btnleyd5.onClick.AddListener(()=>StartCoroutine( Empresa(5,4)));
	    
	    btn6.onClick.AddListener(()=>StartCoroutine( Empresa(6,4)));
	    btnleyd6.onClick.AddListener(()=>StartCoroutine( Empresa(6,4)));
	    
	    btn7.onClick.AddListener(()=>StartCoroutine( Empresa(7,4)));
	    btnleyd7.onClick.AddListener(()=>StartCoroutine( Empresa(7,4)));
	    
	    
	    btn8.onClick.AddListener(()=>StartCoroutine( Empresa(8,4)));
	    btnleyd8.onClick.AddListener(()=>StartCoroutine( Empresa(8,4)));
	    
		btn2D.onClick.AddListener(()=> StartCoroutine(IRmapa2D()));
		btnNom2D.onClick.AddListener(()=> StartCoroutine(IRmapa2D()));
	    //  BtnDispensario.onClick.AddListener(()=> InfoDis());
	    
	    
	    
	    btn3D.onClick.AddListener(() => StartCoroutine(IRmapa3D()));
	    // btnNom3D.onClick.AddListener(()=> IRmapa3D());
	    btnNom3D.onClick.AddListener(() => StartCoroutine(IRmapa3D()));
		BtnAtras3d.onClick.AddListener(()=> StartCoroutine(Iniciox3D()));
	    //  btn2D.onClick.AddListener(()=> Categoria(1));
        
	  
	    flechaD.onClick.AddListener(()=>MoverD());
	    FlechaI.onClick.AddListener(()=>MoverI());
	    BuscaPlano.onClick.AddListener(()=>PF.SetActive(true));
	   
	    
		
	}
    
    
	public	IEnumerator Iniciox3D()
	{
		int y=1630;
		float sec=0.0000000001f;
		
		ventana=2;
		infoEmpresa.SetActive(false);
		Inicio.SetActive(true);
		//Mapa2D.transform.position = new	Vector3(966,y,0f);
		
		for (int i = y; i >= 540;i-=100) {
			Inicio.transform.position = new	Vector3(1170,i,0);
			yield return new WaitForSeconds(sec);
			
		}
		Inicio.transform.position = new	Vector3(1170,540,0);
		
		
		ZonaFranca.SetActive(false);
		
	}//Fin IRmapa2D
    
    


	public	IEnumerator Volver2D()
	{
		
		
		ventana=2;
		Inicio.SetActive(false);
		ZonaFranca.SetActive(false);
		Mapa2D.SetActive(true);
		int x=1180;
		float sec=0.00000001f;
		
		for (int i = x; i <= 4000;i+=100) {
			infoEmpresa.transform.position = new	Vector3(i,540,0);
			yield return new WaitForSeconds(sec);
			Debug.Log(infoEmpresa.transform.position);
			
		}
		infoEmpresa.transform.position = new	Vector3(4000,540,0);
		
		//	infoEmpresa.SetActive(false);
		
	}//Fin IRmapa2D



	public	IEnumerator IRmapa2D()
	{
		int y=1630;
		float sec=0.0000000001f;
		
		ventana=2;
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(false);
		//Mapa2D.transform.position = new	Vector3(966,y,0f);
		Mapa2D.SetActive(true);
		for (int i = y; i >= 540;i-=100) {
			Mapa2D.transform.position = new	Vector3(1170,i,0);
			yield return new WaitForSeconds(sec);
			
		}
		Mapa2D.transform.position = new	Vector3(1170,540,0);
		
		Inicio.SetActive(false);
		
	}//Fin IRmapa2D
	
	
	public IEnumerator back()
	{
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(false);
		Inicio.SetActive(true);
		int y=1630;
		float sec=0.0000000001f;
		
		for (int i = 540; i <= y;i+=100) {
			Mapa2D.transform.position = new	Vector3(1170,i,0);
			yield return new WaitForSeconds(sec);
			
		}
		Mapa2D.transform.position = new	Vector3(1170,y,0);
		
		
		
		Mapa2D.SetActive(false);	
		
	}// fin back

	
	
	
	
	
	public IEnumerator IRmapa3D()
	{
		ventana=3;
		
		Mapa2D.SetActive(false);
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(true);
		objeto=Dispensario.transform;
		
		
		int y=1630;
		float sec=0.0000000001f;
		
		for (int i = 540; i <= y;i+=100) {
			Inicio.transform.position = new	Vector3(1170,i,0);
			yield return new WaitForSeconds(sec);
			
		}
		Mapa2D.transform.position = new	Vector3(1170,y,0);
		Inicio.SetActive(false);
		
		
		if (tuto<=0)
		{
			Tuto1.SetActive(true);
			yield return new WaitForSeconds(3);
			Tuto1.SetActive(false);
			Tuto2.SetActive(true);
			yield return new WaitForSeconds(5);
			Tuto2.SetActive(false);
			Tuto3.SetActive(true);
			yield return new WaitForSeconds(10);
			Tuto3.SetActive(false);
			tuto=1;
		}
		
		
		
	}//Fin IRmapa3D



	public	IEnumerator Empresa(int emp,int ven)
	{
		ventana=ven;
		Inicio.SetActive(false);
		
		infoEmpresa.SetActive(true);
		ZonaFranca.SetActive(false);
		
		if (ven==4)
		{
			BtnAtrasMap.onClick.AddListener(()=> StartCoroutine(Volver2D()));	
		}
		if(ven==5){
			BtnAtrasMap.onClick.AddListener(()=> StartCoroutine(Volver3D()));
		}
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
		
		int x=3000;
		float sec=0.00000001f;
		
		for (int i = x; i >= 1180;i-=170) {
			infoEmpresa.transform.position = new	Vector3(i,540,0);
			yield return new WaitForSeconds(sec);
			Debug.Log(infoEmpresa.transform.position);
			
		}
		infoEmpresa.transform.position = new	Vector3(1170,540,0);
		
		
		Mapa2D.SetActive(false);	
		
		
		
		
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
	
	
	public	IEnumerator Volver3D()
	{
		//	Reubica.SetActive(true);
		//	Atras3D.SetActive(true);
		
		Mapa2D.SetActive(false);
		Inicio.SetActive(false);
		
		
		
		
		int x=3000;
		float sec=0.00000001f;
		
		for (int i = x; i >= 1180;i-=170) {
			infoEmpresa.transform.position = new	Vector3(i,540,0);
			yield return new WaitForSeconds(sec);
			Debug.Log(infoEmpresa.transform.position);
			
		}
		infoEmpresa.transform.position = new	Vector3(1170,540,0);
		
		
		infoEmpresa.SetActive(false);
		ZonaFranca.SetActive(true);
		
	} 
	
	
	
}// fin de public 
