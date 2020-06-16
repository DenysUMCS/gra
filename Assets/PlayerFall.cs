using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{

   private Rigidbody rb;
   private Rigidbody last;
   private int j=0;
   void Start() {
    	rb   =   GetComponent<Rigidbody> ();
      last = rb;
   }

   void Update() {

      RaycastHit hit;
      Physics.Raycast (transform.position, Vector3.down, out hit, 5f);
      
      if(Physics.Raycast (transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "Ground") {
        if(last !=hit.rigidbody)
            ScoreScript.scoreVal += 1;
        last = hit.rigidbody;
      } else if(Physics.Raycast (transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "block"){
         ScoreScript.scoreVal -=1;
      }

   }
}
