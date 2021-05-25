//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Audio;
//using UnityEngine.SceneManagement;

public class playerpool : MonoBehaviour {
    Rigidbody2D playerbody;
    public AudioSource jumpaudio;
	// Use this for initialization
	void Start () {
        playerbody = GetComponent<Rigidbody2D>();
        jumpaudio = GetComponent<AudioSource>();
	}

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            jump();
        }
    }
    public void jump() {
        jumpaudio.Play();
        playerbody.velocity= new Vector2(0,0);
        playerbody.AddForce(new Vector2(0,250));
        jumpaudio.Play();
    }
  
    }

