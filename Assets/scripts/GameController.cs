//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public Text highscore1pg;
	public Animator levelanim;
 
    
    public GameObject levelpanel; 
	// Use this for initialization
	void Start () {
        highscore1pg.text = PlayerPrefs.GetInt("highscorepref", 0).ToString();
        levelpanel.gameObject.SetActive(false);
        PlayerPrefs.SetInt("level", 0);
		levelanim = GetComponent<Animator> ();
	//	Time.timeScale = 0f;
//		levelanim.GetComponent<Animator>.updateMode = AnimatorUpdateMode.UnscaledTime; 
    }
	

    public void startb() {
        
        levelpanel.gameObject.SetActive(true);
        
    }

    public void quit() {
        //UnityEditor.EditorApplication.isPlaying = false;
        //System.Diagnostics.Process.GetCurrentProcess().Kill();
        Application.Quit();
       
		//Application.isPlaying = false; 
    }
    
    public void levelbeasy() {
        //   if (gameObject.name == "easy") {
        PlayerPrefs.SetInt("level", 1);

        SceneManager.LoadScene("gameplay");
       // }
        //if (gameObject.name == "hard") {
          
        //}
    }
    public void levelbhard() {
        PlayerPrefs.SetInt("level", 2);
        SceneManager.LoadScene("gameplay");

    }


}
