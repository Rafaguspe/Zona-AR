using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class botonm : MonoBehaviour
{
	public Button flechaDerecha, flechaizquierda;
	public GameObject Contenedor;

	
	void Start(){
		
		flechaDerecha.onClick.AddListener(()=> moverD());
	
	}
	
	void moverD(){
		double Posx,Posy,Posz;
		Posx=-1700;
		Posy=-7.629395e-06;
		Posz=0;
		
		float x,y,z;
		
		x=(float) Posx;
		y= (float)Posy;
		z= (float)Posz;
		
		Contenedor.transform.position = new	Vector3(-1000,0f,0f);
		
		
		Debug.Log("Imprime y="+y);
	}
	
}