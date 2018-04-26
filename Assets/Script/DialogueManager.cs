using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	public bool dialogActivate;

	public string[] dialogLines;
	public int currentLines;

	//private PlayerScript player;
	private QuestQuestion theQQ;

	// Use this for initialization
	void Start () {
		//player = FindObjectOfType<PlayerScript>();
		theQQ = FindObjectOfType<QuestQuestion>();
	}

	// Update is called once per frame
	void Update () {
		if(dialogActivate && theQQ.resposta || theQQ.rContinuar){
			//if(dialogActivate && Input.GetKeyDown(KeyCode.Space)){
			theQQ.resposta = false;
			theQQ.rContinuar = false;
			currentLines++;
		}

		if(currentLines >= dialogLines.Length){
			dBox.SetActive(false);
			dialogActivate = false;
			currentLines = 0;
			//player.canMove = true;

			theQQ.ButtonResposta1.gameObject.SetActive(false);
			theQQ.ButtonResposta2.gameObject.SetActive(false);
			theQQ.ButtonRespostaContinuar.gameObject.SetActive(false);
		}
		dText.text = dialogLines[currentLines];
	}

	public void ShowBox(string dialog){
		dialogActivate = true;
		dBox.SetActive(true);
		dText.text = dialog;
	}

	public void ShowDialogue(){
		dialogActivate = true;
		dBox.SetActive(true);
		theQQ.ButtonRespostaContinuar.gameObject.SetActive(true);
		//player.canMove = true;
	}



}
