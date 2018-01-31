using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightAndUpDown : MonoBehaviour {

	public float amplitude, frequency;

	Vector2 startPosition;
	Vector3 startRotation;

	void Start () {
		startPosition = transform.position;
	}

	void Update () {
		var newY = startPosition.y + amplitude * Mathf.Cos(Time.time * frequency);
		var newZ = startRotation.z - (amplitude * 20) * Mathf.Sin(Time.time);

		transform.eulerAngles = new Vector3 (0f, 0f, newZ);
		transform.position = new Vector2 (transform.position.x + 0.01f,newY );

		if (transform.position.x >= 7.8f) {
			transform.position = new Vector2 (-transform.position.x + 0.01f,newY );
		}
	}
}