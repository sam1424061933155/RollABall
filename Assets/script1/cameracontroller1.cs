﻿using UnityEngine;
using System.Collections;

public class cameracontroller1 : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}
