﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

	public GameObject player;
	public Vector3 offset;
	public GameObject sea;
	void Start () {
	    offset = transform.position - player.transform.position;
	}
	
   	void Update () {
    	transform.position = player.transform.position + offset;
    	sea.transform.position=new Vector3(player.transform.position.x,-2.0f,player.transform.position.z-50.0f);
    }
}
