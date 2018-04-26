using UnityEngine;
using System.Collections;

public class PlayerStartPoint : MonoBehaviour {

	private PlayerScript thePlayer;
	private CameraControler theCamera;
	public Vector2 startDirection;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerScript>();
		thePlayer.transform.position = transform.position;
		thePlayer.lastMove = startDirection;

		theCamera = FindObjectOfType<CameraControler>();
		theCamera.transform.position = new Vector3(transform.position.x,transform.position.y,theCamera.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
