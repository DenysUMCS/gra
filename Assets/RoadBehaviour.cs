using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using System.IO;
using System.Text;
public class RoadBehaviour : MonoBehaviour
{

	public GameObject road; // Префаб участка пути
	public GameObject left_road_end; // Префаб участка пути
	public GameObject right_road_end;
	public GameObject road_90;
	public GameObject block_road_90;
	public GameObject block_road;
	private int next_el = 0;
	private int cur_el = 0;
	private int prev_el = 0;
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
	    //last_el=0;
	    InvokeRepeating ("SpawnPlatform", 1f, 0.15f);
	}

   void SpawnPlatform() {
   	prev_el = cur_el;
   	cur_el=next_el;
  	next_el = Random.Range (0, 2);
  	Debug.Log(cur_el.ToString()+" "+next_el.ToString());
  	GameObject _platform ;//
    if(next_el==1 && cur_el==1){
    	if(Random.Range (0, 20)==7)
    		_platform = Instantiate (block_road_90) as GameObject;
    	else _platform = Instantiate (road_90) as GameObject;
    	_platform.transform.position = lastpos + new Vector3 (0f,0f,-1f);
    }
    else if(next_el==1 && cur_el==0){
    	_platform = Instantiate (right_road_end) as GameObject;
    	_platform.transform.position = lastpos + new Vector3 (-1f,0f,0f);
    }
    else if(next_el==0 && cur_el==1){
    	_platform = Instantiate (left_road_end) as GameObject;
    	_platform.transform.position = lastpos + new Vector3 (0f,0f,-1f);
    }
    else {//else if(next_el==0 && cur_el==0){
    	if(Random.Range (0, 20)==7)
    		_platform = Instantiate (block_road) as GameObject;
    	else _platform = Instantiate (road) as GameObject;
    	_platform.transform.position = lastpos + new Vector3 (-1f,0f,0f);
    }    

      /*if (next_el == 0 && cur_el==0 && prev_el==0) { // Установить префаб по оси X        
          _platform = Instantiate (road_90) as GameObject;
          if(cur_el == 1 && next_el==0)
         	_platform = Instantiate (right_road_end) as GameObject;
         else _platform = Instantiate (road_90) as GameObject;
         _platform.transform.position = lastpos + new Vector3 (-1f,0f,0f);

      } else { // Установить префаб по оси Z
		 if(cur_el==0 && next_el == 1)
         	_platform = Instantiate (left_road_end) as GameObject;
         else _platform = Instantiate (road) as GameObject;

         _platform.transform.position = lastpos + new Vector3 (0f,0f,-1f);
      }*/
      lastpos = _platform.transform.position;
   }
}