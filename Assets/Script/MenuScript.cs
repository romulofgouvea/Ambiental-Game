using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public GUIStyle style;
	public GUIStyle styleLabel;
	private int buttonwidth = Screen.width / 11;
	private int buttonheight = Screen.height / 7;
	public Texture fundoTextura;
	private string instruction = "";
	// Use this for initialization
	void Start () {
		//myButton = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		
		GUI.skin.button = style;
		//GUILayout.Button("This is a button.");
		
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), fundoTextura);
		GUI.Label (new Rect (Screen.width / 4, Screen.height / 6, Screen.width/2, Screen.height/2), instruction,styleLabel);
		//GUI.Label (new Rect (Screen.width / 2 - buttonwidth/2, Screen.height/2 - buttonheight/2+35, 500, 500), "Precione qualque tecla para INICIAR");
		if (GUI.Button (new Rect (Screen.width - buttonwidth*9 / 2, Screen.height - buttonheight*6 / 2, buttonwidth, buttonheight),"")) {
			//if(Input.anyKey){
			Application.LoadLevel(1);
			//}
		}
		
	}

	public void btExit(){
		Debug.Log("btExit");
		Application.Quit();
	}

}
