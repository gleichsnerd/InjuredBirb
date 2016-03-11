using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {

	public GameObject ground;
	public GameObject roof;

	private GameObject currentGround;
	private GameObject oldGround;

	private GameObject currentRoof;
	private GameObject oldRoof;
	private GameObject player;

	// Use this for initialization
	void Start () {
		currentGround = (GameObject) Instantiate (ground, new Vector2 (16, -6), transform.rotation);
		currentRoof = (GameObject) Instantiate (roof, new Vector2 (16, 7), transform.rotation);
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (currentGround.GetComponent<Renderer> ().bounds.size.x + currentGround.transform.position.x - player.transform.position.x < 60) {
			if (oldGround != null)
				Destroy (oldGround);
			oldGround = currentGround;
			currentGround = (GameObject)Instantiate (ground, new Vector2 (oldGround.GetComponent<Renderer> ().bounds.size.x + oldGround.transform.position.x, -6), transform.rotation);
		}

		if (currentRoof.GetComponent<Renderer> ().bounds.size.x + currentRoof.transform.position.x - player.transform.position.x < 60) {
			if (oldRoof != null)
				Destroy (oldRoof);
			oldRoof = currentRoof;
			currentRoof = (GameObject)Instantiate (roof, new Vector2 (oldRoof.GetComponent<Renderer> ().bounds.size.x + oldRoof.transform.position.x, 7), transform.rotation);
		}
	}
}
