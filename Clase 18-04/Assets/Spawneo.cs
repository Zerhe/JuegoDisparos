using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawneo : MonoBehaviour {
    public int rangoSpawn;
    public GameObject[] objsToSpawn;
    private Vector3 placeToSpawn;
    private int objtToSpawn;
    
    float timer;

	void Start () {
        placeToSpawn = transform.position;
	}
	
	void Update () {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            objtToSpawn = Random.Range(0, objsToSpawn.Length);
            placeToSpawn.x = Random.Range(0, objtToSpawn);
            placeToSpawn.z = Random.Range(0, objtToSpawn);

            Instantiate(objsToSpawn[objtToSpawn], placeToSpawn, transform.rotation);
            timer = 0;
        }
	}
}
