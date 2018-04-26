using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestTrigger : MonoBehaviour {

	private QuestManager theQM;
	private QuestQuestion theQQ;

	public int questNumber;

	public bool startQuest;
	public bool endQuest;


	// Use this for initialization
	void Start () {
		theQM = FindObjectOfType<QuestManager>();
		theQQ = FindObjectOfType<QuestQuestion>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name == "Player"){
			if(!theQM.questCompleted[questNumber]){
				if(startQuest && !theQM.quest[questNumber].gameObject.activeSelf){
					theQM.quest[questNumber].gameObject.SetActive(true);
					theQM.quest[questNumber].StartQuest();

					if(!theQM.quest[questNumber].isItemQuest){
						theQQ.ButtonResposta1.gameObject.SetActive(true);
						theQQ.ButtonResposta2.gameObject.SetActive(true);
					}else{
						theQM.ButtonRespostaContinuar = true;
					}
				}

				if(endQuest && theQM.quest[questNumber].gameObject.activeSelf){
					theQQ.ButtonResposta1.gameObject.SetActive(false);
					theQQ.ButtonResposta2.gameObject.SetActive(false);
					theQM.ButtonRespostaContinuar = false;

					theQM.quest[questNumber].EndQuest();
				}
			}
		}
	}


}
