using UnityEngine;
using System.Collections;

public class DialogHolder : MonoBehaviour {

	public string dialogue;
	private DialogueManager dMan;

	private PlayerScript player;

	public string[] dialogueLines;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
		player = FindObjectOfType<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.name == "Player"){
			if(!dMan.dialogActivate){
				dMan.dialogLines = dialogueLines;
				dMan.currentLines = 0;
				dMan.ShowDialogue();
			}
		}
	}
}
