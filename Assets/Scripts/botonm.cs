using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Botonesdelscroll : MonoBehaviour
{
	public Button flechaDerecha, flechaizquierda;
	public GameObject Contenedor;

	
	void star(){
		
		flechaDerecha.onClick.AddListener(()=> moverD());
	}
	
	void moverD(){
		
		Contenedor.transform.position = new	Vector3(-1761,-7,0);
		
		
	}
	
}