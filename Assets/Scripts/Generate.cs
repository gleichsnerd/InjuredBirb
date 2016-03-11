using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject branches;
	public GameObject logs;
	public int bRange = 4;
	public float lRange = -1.5f;
	private Queue branchQueue = new Queue ();
	private Queue logQueue = new Queue ();

	private GameObject player;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("createVerticalObstacle", 1f, 2f);
		InvokeRepeating ("createLogObstacle", 10f, 5f);

		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void createVerticalObstacle() {
		GameObject branch = (GameObject) Instantiate (branches, new Vector2(player.transform.position.x + 15, 4 + bRange * Random.value), transform.rotation);
		branchQueue.Enqueue (branch);
	}

	void createLogObstacle() {
		GameObject log = (GameObject) Instantiate (logs, new Vector2 (player.transform.position.x + 15, -5 + lRange * Random.value), transform.rotation);
		logQueue.Enqueue (log);
	}

	void Update() {
		if (branchQueue.Count > 5) {
			Destroy ((GameObject) branchQueue.Dequeue());
		}

		if (logQueue.Count > 2) {
			Destroy ((GameObject)logQueue.Dequeue ());
		}
	}

}
