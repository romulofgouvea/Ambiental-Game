using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float playerSpeed;

	private Animator anim;
	private Rigidbody2D mRigidbody2D;

	private bool playerMoving;
	public Vector2 lastMove;

	private static bool playerExists;

	private DialogueManager dMan;

	public bool canMove;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		mRigidbody2D = GetComponent<Rigidbody2D>();

		if(!playerExists){
			playerExists = true;
			DontDestroyOnLoad( transform.gameObject );
		}else{
			Destroy(gameObject);
		}
		dMan = FindObjectOfType<DialogueManager>();

		canMove = false;
	}
	
	// Update is called once per frame
	void Update () {
		playerMoving = false;

		if(dMan.dialogActivate){
			canMove = true;
		}else{
			canMove = false;
		}

		if(canMove){
			//Debug.Log("freeze");
			mRigidbody2D.velocity = Vector2.zero;
			return;
		}

		if(Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f){
			//transform.Translate(new Vector3(Input.GetAxisRaw ("Horizontal") * playerSpeed * Time.deltaTime,0f,0f));
			mRigidbody2D.velocity = new Vector2(Input.GetAxisRaw ("Horizontal")* playerSpeed ,mRigidbody2D.velocity.y);
			playerMoving = true;
			lastMove = new Vector2(Input.GetAxisRaw ("Horizontal"),0f);
		}
		if(Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f){
			//transform.Translate(new Vector3(0f,Input.GetAxisRaw ("Vertical") * playerSpeed * Time.deltaTime,0f));
			mRigidbody2D.velocity = new Vector2(mRigidbody2D.velocity.x,Input.GetAxisRaw ("Vertical")* playerSpeed);
			playerMoving = true;
			lastMove = new Vector2(0f,Input.GetAxisRaw ("Vertical"));
		}

		if(Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f){
			mRigidbody2D.velocity = new Vector2(0f,mRigidbody2D.velocity.y);
		}
		if(Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f){
			mRigidbody2D.velocity = new Vector2(mRigidbody2D.velocity.x,0f);
		}
		anim.SetFloat( "MoveX",Input.GetAxisRaw ("Horizontal") );
		anim.SetFloat( "MoveY",Input.GetAxisRaw ("Vertical") );
		anim.SetBool("PlayerMoving", playerMoving);
		anim.SetFloat("LastMoveX",lastMove.x);
		anim.SetFloat("LastMoveY",lastMove.y);

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name == "LoadQuestion"){
			if(!playerMoving){
				mRigidbody2D.velocity = Vector2.zero;
				return;
			}
			//Debug.Log("Player Encostou");
			//if(Input.GetKeyDown(KeyCode.Space)){
			//	dMan.ShowBox("deu certo");
			//}
			//other.gameObject.SetActive(false);
			//gameObject.transform.position = new Vector2(other.gameObject.transform.position.x + 1,other.gameObject.transform.position.y);

		}
	}

}
