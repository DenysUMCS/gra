using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereBehavior : MonoBehaviour
{

   private Rigidbody rb; // Объявление новой переменной Rigidbody
   private bool isMovingRight = true; // переменная, отражающая условное направление объекта
   public int ballspeed = 0; // Скорость движения объекта
   public GameObject score_info;
   void Start() {
      rb = GetComponent<Rigidbody> (); // Получение доступа к Rigidbody
   }

   void changeDirection() {
      isMovingRight=!isMovingRight;
   }

   void Update() {
      if(Input.GetMouseButtonDown(0)) {
         changeDirection();
      }
      //score_info.text = "Score : "+"asdfs";
      if (isMovingRight) {
         rb.velocity = new Vector3 (-ballspeed, 0f, 0f);
      } else {
         rb.velocity = new Vector3 (0f, 0f, -ballspeed);
      }

   }
}
