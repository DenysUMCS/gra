using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBehaviour : MonoBehaviour
{

   public GameObject road; // Префаб участка пути
   private Vector3 lastpos = new Vector3 (0f,0f,0f); // Координаты установленного префаба

   void Start() {

      for(int i=0; i<10; i++) {
         GameObject _platform = Instantiate (road) as GameObject;
         _platform.transform.position = lastpos + new Vector3 (1f,0f,0f);
         lastpos = _platform.transform.position;
      }

   }
}
