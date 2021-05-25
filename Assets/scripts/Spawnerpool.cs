//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerpool : MonoBehaviour {
    public float minx, maxy,maxx;
    public GameObject obstacle;
    public int score = 0;
    public Text scoretext,highscoretext;
   // public bool playerin = true;
    public Transform target;
    PlayerPrefs highscore;
    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("alive",0);
        InvokeRepeating("spawnobstacle",1f,2.5f);
        Vector3 bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        minx = -bound.x;
        maxy = bound.y;
        maxx = bound.x;
      

    }
	
	// Update is called once per frame
	void Update () {
        scoretext.text = score.ToString();
        if (target.transform.position.x < minx || target.transform.position.y > maxy || target.transform.position.x > maxx)
        {

            PlayerPrefs.SetInt("alive",1);
        }
        if (score > PlayerPrefs.GetInt("highscorepref", 0))
        {
            PlayerPrefs.SetInt("highscorepref", score);
        }
        highscoretext.text = PlayerPrefs.GetInt("highscorepref", 0).ToString();
    }
    void spawnobstacle() {
        Instantiate(obstacle, transform.position, Quaternion.identity);
        if (PlayerPrefs.GetInt("alive",0)==0)
        {
            
                score++; 
        }
        
        if (score > 120) {
            PlayerPrefs.SetInt("level", 2);
        }
    }
}
