using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public Text countText;
	public Text winText;
	
	private Rigidbody rb;
	private int count;
    private int timer_i;

	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
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
		if (other.gameObject.CompareTag ( "PickUp"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
            TimeCounter.timer_i += 3;
            Debug.Log(TimeCounter.timer_i);
            
        }
	}
	
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12)
		{
			winText.text = "You Win!";
		}
	}

    void EndGame ()
    {
        if (timer_i <= 0)
        {
            speed = 0;
        }
    }
}