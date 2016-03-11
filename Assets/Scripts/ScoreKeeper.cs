using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	private DateTime startTime;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		this.startTime = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		double score = Math.Round (DateTime.Now.Subtract (startTime).TotalMilliseconds / 100);
		this.scoreText.text = "Score: " + score.ToString ();
		Pitpex.SetScore (score);
	}
}
