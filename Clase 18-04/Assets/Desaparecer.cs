using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer : MonoBehaviour {
    RaycastHit infColi;
    Renderer rend;
    Renderer rendPrev;
    void Start () {
		
	}
	
	void Update () {
        if (Physics.Raycast(transform.position, transform.up , out infColi))
        {
            rend = infColi.transform.GetComponent<Renderer>();
            rend.enabled = false;
            if (rendPrev == null)
            {
                rendPrev = rend;
            }
            if (rend != rendPrev)
            {
                rendPrev.enabled = true;
            }
            rendPrev = rend;
        }
        else if (!Physics.Raycast(transform.position, transform.up, out infColi) && rend.enabled == false)
        {
            rend.enabled = true;
        }
    }
}
