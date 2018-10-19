using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMove : MonoBehaviour {

    public float speed = 1f;
    public Vector3 target;
    public float timer = 1f;
    private float timeLeft;
    float rand1;
    float rand2;

    void Start() {

        timeLeft = timer;

        rand1 = Random.Range(-1f, 1f);
        rand2 = Random.Range(-1f, 1f);

        target = new Vector3(rand1,rand2, 0);
    }
    // Update is called once per frame
    void FixedUpdate() {
        timeLeft -= Time.deltaTime;


        if (timeLeft <= 0) {

            //if(rand1 >= 0) {
            //    rand1 = Random.Range(-1f, 0f);
            //}
            //else {
            //    rand1 = Random.Range(0f, 1f);
            //}
            //if (rand2 >= 0) {
            //    rand2 = Random.Range(-1f, 0f);
            //}
            //else {
            //    rand2 = Random.Range(0f, 1f);
            //}


            rand1 = Random.Range(-1f, 1f);
            rand2 = Random.Range(-1f, 1f);


            target = new Vector3(rand1, rand2, 0);

            timeLeft = timer;
        }

        target = target.normalized * speed;

        GetComponent<Rigidbody2D>().MovePosition(transform.position + target * Time.deltaTime);

    }
}
