using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
    public int fuerzaDisparo;
	void Start () {

	}
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit infColi;

            if (Physics.Raycast(transform.position, transform.up, out infColi))
            {
                infColi.rigidbody.AddForceAtPosition(transform.up * fuerzaDisparo, infColi.point, ForceMode.Impulse);

            }
        }
	}
}
