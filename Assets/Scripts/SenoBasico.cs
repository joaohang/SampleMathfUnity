using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoBasico : MonoBehaviour {

	Vector2 startPosition;

	void Start () {
		//Armazenando a posição inicial do objeto
		startPosition = transform.position;
	}

	void Update () {
		//Aplicação do seno y=sen x
		var newY = startPosition.y + Mathf.Sin(Time.time); // Somente de 1 a -1
		//var newX = startPosition.x + Mathf.Sin(Time.time);

		//Atualizando a posição
		transform.position = new Vector2 (
			transform.position.x,
			//newX,
			newY
		);

	}
}
