﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage2 : MonoBehaviour {
	public int HP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (HP);
	}
	public void minHP (){
		HP --;
	}
	public void prHP (){
		HP ++;
	}
}
