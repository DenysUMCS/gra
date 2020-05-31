using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class jump : MonoBehaviour
{
	public int ballspeed = 0; // Скорость движения объекта
   	public int jumpspeed = 0;
	Rigidbody rb;
  	void Start()
 	{
    	rb = GetComponent<Rigidbody>();
  	}
    

  	void Update()
 	{
 		float hmove = Input.GetAxis("Horizontal");
      	float vmove = Input.GetAxis("Vertical");
        Vector3 ballmove = new Vector3(hmove,0.0f,vmove);
 		if(Input.GetKey(KeyCode.Space) && rb && rb.position.y<1.1f){
 			Vector3 balljump = new Vector3(0.0f,80.0f,0.0f);
         	rb.AddForce(balljump*jumpspeed);
      	}
  	}
}
