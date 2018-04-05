﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			if (hit.collider != null) {
				Debug.Log(hit.collider.gameObject.name);
				hit.collider.attachedRigidbody.AddForce(Vector2.up);
				Destroy (hit.collider.gameObject);
				score++;
				scoreText.text = "Score: " + score.ToString ();
				Debug.Log ("score: " + score);
			}
		}
	}
}
