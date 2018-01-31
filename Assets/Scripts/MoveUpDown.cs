using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour {

	public float amplitude, frequency;
	Vector2 startPosition;

	void Start () {
		startPosition = transform.position;
	}

	void Update () {
		var newY = startPosition.y + amplitude * Mathf.Sin(Time.time * frequency);

		transform.position = new Vector2 (transform.position.x, newY);
	}
}
