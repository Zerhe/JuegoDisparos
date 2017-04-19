﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
    public float velMov;
    public float velRot;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velMov);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -velMov);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate (Vector3.up * Time.deltaTime * velRot);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -velRot);
        }
    }
}
