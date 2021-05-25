//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class death : MonoBehaviour {
    public float minx, maxy,maxx;
    public GameObject gameover,jump;
    public Transform target;
    public GameController gc;
    PlayerPrefs alive;
   // public Spawnerpool spawn;
    //public Spawnerpool p;
    
	// Use this for initialization
	void Start () {
        Vector3 bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
        minx= -bound.x;
       maxx= bound.x;
        //miny = -bound.y;
        maxy = bound.y;
        gameover.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (target.transform.position.x < minx || target.transform.position.y > maxy || target.transform.position.x > maxx) {
            jump.SetActive(false);
            gameover.SetActive(true);
			//Time.timeScale = 0f;
           // p.playerin = false;
        }
       
         
        
        
        
	}
    public void mainmenu() {
                   SceneManager.LoadScene("MainMenu");
        
    }
    void OnCollisionEnter2D(Collision2D collision) {
      
            if (PlayerPrefs.GetInt("level",0)==2)
            {
                jump.SetActive(false);
                gameover.SetActive(true);
            PlayerPrefs.SetInt("alive", 1);

        }
    }
}
