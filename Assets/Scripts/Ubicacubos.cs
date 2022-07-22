using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ubicacubos : MonoBehaviour
{
	Manager mana;
	arRaycaster ray;
	
	public TMP_Text Descripcion;
	RaycastHit2D ray2d;
	public float distan;
    // Start is called before the first frame update
    void Start()
	{
		mana=GameObject.FindGameObjectWithTag("TagMana").GetComponent<Manager>();
		ray=GameObject.FindGameObjectWithTag("TagRay").GetComponent<arRaycaster>();
    }

    // Update is called once per frame
    void Update()
	{
		
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch(0);
			var touchPositon = touch.position;
		
	
		
		
		
		}
		
	}
		
}
