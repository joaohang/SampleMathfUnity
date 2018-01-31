using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class RotationAndColor : MonoBehaviour {

	public float amplitude, frequency;
	Vector3 startRotation;
	public float newColor;
	SpriteRenderer sp;
	void Start () {
		startRotation = transform.eulerAngles;
	}	

	void Update () {
		var newZ = startRotation.z + amplitude * Mathf.Sin(Time.time * frequency);
		transform.eulerAngles = new Vector3 (0f, 0f, newZ);

		newColor = 0.5f + 0.5f * Mathf.Sin(Time.time);
		GetComponent<SpriteRenderer>().color = new Color(1,1,1, newColor * frequency);
	}
}
