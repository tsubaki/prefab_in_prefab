﻿using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class NestedPrefabChild : MonoBehaviour
{
	public GameObject stepparent;

	void Awake()
	{
		if(Application.isPlaying) Destroy(gameObject);
		Update();
	}

	void Update()
	{
		if(stepparent == null) return;
		this.transform.position = stepparent.transform.position;
		this.transform.rotation = stepparent.transform.rotation;
		this.transform.localScale = stepparent.transform.lossyScale; // set global scale
	}
}