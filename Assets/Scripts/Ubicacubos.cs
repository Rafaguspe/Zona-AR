using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ubicacubos : MonoBehaviour
{
	Manager mana;
	arRaycaster ray;
	public GameObject c1,c2,c3,c4;
	public TMP_Text Descripcion;
	
    // Start is called before the first frame update
    void Start()
	{
		mana=GameObject.FindGameObjectWithTag("TagMana").GetComponent<Manager>();
		ray=GameObject.FindGameObjectWithTag("TagRay").GetComponent<arRaycaster>();
    }

    // Update is called once per frame
    void Update()
	{
		Vector3 ubica=ray.arCamera.transform.position;
    	
		c1.transform.position= new Vector3(ubica.x,ubica.y,ubica.z);
		c2.transform.position= new Vector3(ubica.x,ubica.y,ubica.z);
		c3.transform.position= new Vector3(ubica.x,ubica.y,ubica.z);
		c4.transform.position= new Vector3(ubica.x,ubica.y,ubica.z);
    	
		Vector3 ubi3= c1.transform.position;
		
		string ubi= ubi3.ToString();
	
		
		Descripcion.text= "cubo "+ubi;
        
    }
}
