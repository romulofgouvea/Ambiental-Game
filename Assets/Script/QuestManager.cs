using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour {

	public QuestObject[] quest;
	public bool[] questCompleted;

	public DialogueManager theDM;
	public QuestQuestion theQQ;

	public string itemCollected;

	public bool ButtonRespostaContinuar;

	// Use this for initialization
	void Start () {
		questCompleted = new bool[quest.Length];
	}
	
	// Update is called once per frame
	void Update () {
		theQQ.ButtonRespostaContinuar.gameObject.SetActive(ButtonRespostaContinuar);
	}

	public void ShowQuestText(string questText){
		theDM.dialogLines = new string[1];
		theDM.dialogLines[0] = questText;
		theDM.currentLines = 0;


		theDM.ShowDialogue();
	}

}
