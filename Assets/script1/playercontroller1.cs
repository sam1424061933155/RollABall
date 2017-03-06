using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playercontroller1 : MonoBehaviour {

	public float speed;

	public Text CountText;
	public Text WinText;
	public Text me;


	private Rigidbody rb;
	private AudioSource aud;
	private ParticleSystem ps;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		aud = GetComponent<AudioSource> ();
		ps = GetComponent<ParticleSystem> ();
		count = 0;
		SetCountText ();
		WinText.text = "";
		me.text="學號：0556039";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			aud.Play ();
			ps.Play ();
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		CountText.text = "Count : " + count.ToString();

		if (count >= 7) 
		{
			WinText.text="You Win!!";
		}

	}
}
