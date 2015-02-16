﻿using UnityEngine;
using System.Collections;

public class SelfDestruct : TempObject {

	public float lightFade;
	private Light light;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
    void Update()
    {
        light.intensity -= lightFade;
    }
		
}
