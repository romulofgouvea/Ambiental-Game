using UnityEngine;
using System.Collections;

public class LoadNewQuestion : MonoBehaviour {

	public string LevelLoad;
	private static bool loadQuestionExists;
	private static bool count;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(loadQuestionExists){
			transform.gameObject.SetActive(false);
		}
		count = false;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name == "Player"){
			loadQuestionExists = true;
			if(!count){
				Application.LoadLevel(LevelLoad);
				count  = true;
			}
		}

	}
}
