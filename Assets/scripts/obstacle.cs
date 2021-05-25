//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Translate(new Vector3(0,Random.Range(-2,3)));
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left*2*Time.deltaTime);
        if (transform.position.x < -14.5) {
            gameObject.SetActive(false);
        }
	}
}
