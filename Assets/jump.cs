using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
public int jumpForce= 50;
  
  private bool canJump;
  private Rigidbody rb;
  
  void Start()
 {
      rb = GetComponent<Rigidbody>();
  }
  
  void FixedUpdate()
 {
      if(canJump){
          canJump = false;
          rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
      }
  }
  
  void Update()
 {
      if(Input.GetKeyUp(KeyCode.Space)){
          canJump = true;
      }
  }
}
