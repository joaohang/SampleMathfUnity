using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour {

	public float amplitude, frequency;
	Vector2 startPosition;

	void Start () {
		startPosition = transform.position;
	}

	void Update () {
		var newY = startPosition.y + amplitude * Mathf.Sin(Time.time * frequency);
		var newX = startPosition.x + amplitude * Mathf.Cos(Time.time * frequency);

		transform.position = new Vector2 (newX,newY);
	}
}
