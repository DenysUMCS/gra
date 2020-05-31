using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{

   private Rigidbody rb;
   private Rigidbody[]rb_arr = new Rigidbody[10];
   private int j=0;
   	void Start() {
    	rb = GetComponent<Rigidbody> ();
   	}

   void Update() {

      RaycastHit hit;
      if(Physics.Raycast (transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "Ground") {
        
         rb.useGravity = false;
         
        
      } else {
      	 rb_arr[j%10]=hit.rigidbody;
         rb.useGravity = true;
         j++;
         rb_arr[(j+1)%10].isKinematic=false;
         //Destroy(rb_arr[(j)%10]);
        //hit.rigidbody.isKinematic=false;
         //hit.rigidbody.isKinematic=false;
      }

   }
}
