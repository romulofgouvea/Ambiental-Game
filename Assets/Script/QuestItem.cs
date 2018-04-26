using UnityEngine;
using System.Collections;

public class QuestItem : MonoBehaviour {

	public int questNumber;

	public QuestManager theQM;

	public string itemName;

	public bool startNewQuest;
	public bool endNewQuest;
	public int newQuestNumber;
	// Use this for initialization
	void Start () {
		theQM = FindObjectOfType<QuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name == "Player"){
			if(!theQM.questCompleted[questNumber] && theQM.quest[questNumber].gameObject.activeSelf){
				theQM.itemCollected = itemName;
				gameObject.SetActive(false);
			//}
				theQM.ButtonRespostaContinuar = true;
			//if(startNewQuest && !theQM.quest[newQuestNumber].gameObject.activeSelf && theQM.questCompleted[questNumber]){
				theQM.quest[newQuestNumber].gameObject.SetActive(true);
				theQM.quest[newQuestNumber].StartQuest();
			}
			if(endNewQuest && theQM.quest[newQuestNumber].gameObject.activeSelf){
				//theQQ.ButtonRespostaContinuar.gameObject.SetActive(false);
				theQM.ButtonRespostaContinuar = false;
				theQM.quest[newQuestNumber].EndQuest();
			}
		}
	}


}
