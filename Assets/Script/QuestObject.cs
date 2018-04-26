using UnityEngine;
using System.Collections;

public class QuestObject : MonoBehaviour {

	public int questNumber;

	public QuestManager theQM;
	public QuestQuestion theQQ;

	public string startText;
	public string endText;


	public bool isItemQuest;
	public string targetItem;

	// Use this for initialization
	void Start () {
		//theQM = FindObjectOfType<QuestManager>();
		//theQQ = FindObjectOfType<QuestQuestion>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isItemQuest){
			if(theQM.itemCollected == targetItem){
				EndQuest();
			}
		}else if(theQQ.resposta){

		}
	}

	public void StartQuest(){
		theQM.ShowQuestText(startText);
	}

	public void EndQuest(){
		theQM.ShowQuestText(endText);
		theQM.questCompleted[questNumber] = true;
		gameObject.SetActive(false);
	}
}
