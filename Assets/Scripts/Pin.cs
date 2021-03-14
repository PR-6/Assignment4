using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	private bool isPinned = false;

	public float speed = 20f;
	public Rigidbody2D rb;
	public float speedMultiplyer = 1;
	public GameObject pin;

	void Start()
    {
		speedMultiplyer = PlayerPrefs.GetInt("PinSpeed", 1);
		speed = speed * speedMultiplyer;
    }

	void Update ()
	{
		if (!isPinned)
			rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Rotator")
		{
			transform.SetParent(col.transform);
			Score.PinCount++;
			isPinned = true;
		} else if (col.tag == "Pin")
		{
			if (PlayerPrefs.GetInt("LivesRemaining", 0) > 0){
				PlayerPrefs.SetInt("LivesRemaining", PlayerPrefs.GetInt("LivesRemaining") - 1);
				Destroy(pin);
			}
			else
            {
				FindObjectOfType<GameManager>().EndGame();
			}
			
		}
	}

}
