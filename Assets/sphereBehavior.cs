using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereBehavior : MonoBehaviour
{

   private Rigidbody rb; // Объявление новой переменной Rigidbody
   private bool isMovingRight = true; // переменная, отражающая условное направление объекта
   private float speed = 5f; // Скорость движения объекта

   void Start() {
      rb = GetComponent<Rigidbody> (); // Получение доступа к Rigidbody
   }

   void changeDirection() {
      if (isMovingRight) {
         isMovingRight = false;
      } else {
         isMovingRight = true;
      }
   }

   void Update() {

      if(Input.GetMouseButtonDown(0)) {
         changeDirection();
      }

      if (isMovingRight) {
         rb.velocity = new Vector3 (-speed, 0f, 0f);
      } else {
         rb.velocity = new Vector3 (0f, 0f, -speed);
      }

   }
}
