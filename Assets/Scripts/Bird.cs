using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Bird : MonoBehaviour {

	public float speed = 2;
	public float force = 200;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * force);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Pitpex.GameOver ();
	}

}