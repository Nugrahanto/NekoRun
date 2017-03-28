using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D myRigidBody;
	private Animator myAnim;
	public float playerJumpForce = 500f;
	private float playerHurtTime = -1;
	private Collider2D myCollider;
	public Text scoreText;
	private float startTime;
	private int jumpsLeft = 2;
    public AudioSource jump;
    public AudioSource mati;

    // Use this for initialization
    void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();
		myCollider = GetComponent<Collider2D> ();	

		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
				//Application.LoadLevel ("Title");
			SceneManager.LoadScene("Title");
		}

		if (playerHurtTime == -1) {

			if ((Input.GetButtonUp ("Jump") || Input.GetButtonUp("Fire1")) && jumpsLeft > 0) {

				if (myRigidBody.velocity.y < 0) {
					myRigidBody.velocity = Vector2.zero;
				}

				if (jumpsLeft == 1) {
					myRigidBody.AddForce (transform.up * playerJumpForce * 0.75f);
				} else {
					myRigidBody.AddForce (transform.up * playerJumpForce);
				}
			
				jumpsLeft--;
                jump.Play();

            }
			myAnim.SetFloat ("vVelocity", myRigidBody.velocity.y);
			scoreText.text = ((Time.time - startTime) * 3).ToString ("0");
		} 
		else {
			if (Time.time > playerHurtTime + 2) {
                //Application.LoadLevel (Application.loadedLevel);
				//SceneManager.LoadScene(Application.loadedLevel);              
                
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {

            foreach (RintanganSpawner spawner in FindObjectsOfType<RintanganSpawner>())
            {
                spawner.enabled = false;
            }

            foreach (MoveLeft moveLefter in FindObjectsOfType<MoveLeft>())
            {
                moveLefter.enabled = false;
            }

            playerHurtTime = Time.time;
            myAnim.SetBool("playerHurt", true);
            myRigidBody.velocity = Vector2.zero;
            myRigidBody.AddForce(transform.up * playerJumpForce);
            myCollider.enabled = false;

            mati.Play();

            OnDeath();

			float currentBestScore = PlayerPrefs.GetFloat ("BestScore", 0);
			float currentScore = (Time.time - startTime) * 3;

			if (currentScore > currentBestScore) {
				PlayerPrefs.SetFloat ("BestScore", currentScore);
			}

        }
        
        else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            jumpsLeft = 2;
        }
	}

    void OnDeath()
    {
    	//Application.LoadLevel("Death");
		SceneManager.LoadScene("Death");
    }
}
