using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed = 100f;
	public float speedMultiplyer = 1;

	void Start()
    {
		speedMultiplyer = PlayerPrefs.GetInt("RotateSpeed", 1);
		speed = speed * speedMultiplyer;
    }

	void Update ()
	{
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}

}
