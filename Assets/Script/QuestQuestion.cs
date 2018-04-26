using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestQuestion : MonoBehaviour {

	public bool resposta;
	public bool rContinuar;
	public Button ButtonResposta1;
	public Button ButtonResposta2;
	public Button ButtonRespostaContinuar;

	public void respostaPergunta1(bool i){
		resposta = i;
		Debug.Log("respostaPergunta1 :"+ resposta);
	}
	public void respostaPergunta2(bool i){
		resposta = i;
		Debug.Log("respostaPergunta2 :"+ resposta);
	}
	
	public void respostaContinuar(bool i){
		rContinuar = i;
		Debug.Log("respostaPergunta2 :"+ resposta);
	}
}
