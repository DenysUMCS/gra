using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using System.IO;
using System.Text;
public class RoadBehaviour : MonoBehaviour
{

	public GameObject road; // Префаб участка пути
   	private Vector3 lastpos = new Vector3 (0f,0f,0f); // Координаты установленного префаба
   	GameObject [] roads = new GameObject[10];
   	private int j=0;
	void Start() {
		for(int i=0; i<10; i++) {
	         GameObject _platform = Instantiate (road) as GameObject;
	         _platform.transform.position = lastpos + new Vector3 (-1f,0f,0f);
	         lastpos = _platform.transform.position;
	    	 roads[i]=_platform;
	    }

	    InvokeRepeating ("SpawnPlatform", 1f, 0.15f);
	}

   void SpawnPlatform() {

      int random = Random.Range (0, 2);
      roads[(j)%20] = Instantiate (road) as GameObject;
      if (random == 0) { // Установить префаб по оси X 
         roads[(j)%10].transform.position = lastpos + new Vector3 (-1f,0f,0f);
      } else { // Установить префаб по оси Z
        roads[(j)%10].transform.position = lastpos + new Vector3 (0f,0f,-1f); 
      }
      lastpos = roads[j%10].transform.position;
      //roads[(j+1)%20]=_platform;
      //des();
   	  //roads[(j)%20].transform.position =/* roads[(j+1)%20].transform.position + */new Vector3(0.0f,0.1f,0.0f);
   	  j++;
   	  //if(j>=10) j=0;
   }
   void des(){
   		//while(roads[(j+1)%20].velocity)
   		/*Debug.Log(roads[(j+1)%10].transform.position);
   		while(roads[(j+1)%10].transform.position.y>-10.0f){
   			Debug.Log(roads[(j+1)%10].transform.position);
   			roads[(j+1)%10].transform.position= roads[(j+1)%10].transform.position + new Vector3(0.0f,-0.1f,0.0f);
   		}*/
   		//Destroy(roads[(j+1)%10]);
   }
}