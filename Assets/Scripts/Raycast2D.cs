using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast2D : MonoBehaviour
{
    public float floatHeight;     // Desired floating height.
    public float liftForce;       // Force to apply when lifting the rigidbody.
    public float damping;         // Force reduction proportional to speed (reduces bouncing).

    Rigidbody2D rb2D;
    arRaycaster rayo;
  public  GameObject raycast3dd,marco;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rayo = GameObject.FindGameObjectWithTag("TagRay").GetComponent<arRaycaster>();
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Vector2.zero);

        if (hit.collider != null)
        {
            Debug.Log("Target name: " + hit.collider.name);
        }
       

        else 
        {
	        Debug.Log("No presion target");
        }

    }
}