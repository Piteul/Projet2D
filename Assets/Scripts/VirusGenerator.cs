using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGenerator : MonoBehaviour {
    public GameObject virusPrefab;

    public float reloadTime = 2f;
    public float reloadProgress = 0f;
    float rand1;
    float rand2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        reloadProgress += Time.deltaTime;
        rand1 = Random.Range(-1f, 1f);
        rand2 = Random.Range(-1f, 1f);


        virusPrefab.transform.position = new Vector3(rand1, rand2, 0);

        if(reloadProgress >= reloadTime) {
            Instantiate<GameObject>(virusPrefab);
            reloadProgress = 0;
        }
		
	}
}
