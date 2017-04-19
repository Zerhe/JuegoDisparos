using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer : MonoBehaviour {
    RaycastHit infColi;
    Renderer rend;
    void Start () {
		
	}
	
	void Update () {
        if (Physics.Raycast(transform.position, transform.up , out infColi))
        {
            rend = infColi.transform.GetComponent<Renderer>();
            rend.enabled = false;

        }
    }
}
