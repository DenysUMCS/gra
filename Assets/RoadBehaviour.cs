using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBehaviour : MonoBehaviour
{

	public GameObject road; // Префаб участка пути
   	private Vector3 lastpos = new Vector3 (0f,0f,0f); // Координаты установленного префаба
   	public GameObject [] roads = new GameObject[10];
   	private int j=0;
	void Start() {
		for(int i=0; i<10; i++) {
	         GameObject _platform = Instantiate (road) as GameObject;
	         _platform.transform.position = lastpos + new Vector3 (-1f,0f,0f);
	         lastpos = _platform.transform.position;
	    	 roads[i]=_platform;
	    }

	    InvokeRepeating ("SpawnPlatform", 1f, 0.2f);
	}

   void SpawnPlatform() {

      int random = Random.Range (0, 2);
      GameObject _platform = Instantiate (road) as GameObject;
      if (random == 0) { // Установить префаб по оси X 
         _platform.transform.position = lastpos + new Vector3 (-1f,0f,0f);
      } else { // Установить префаб по оси Z
         _platform.transform.position = lastpos + new Vector3 (0f,0f,-1f); 
      }
      roads[(j+1)%10]=_platform;
      lastpos = _platform.transform.position;
   	  Destroy(roads[(j+3)%10]);
   	  j++;
   }
}
