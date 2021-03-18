using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
	private float speed;
	private System.Random random = new System.Random();
	public int minSpeed = 1;
	public int maxSpeed = 5;
	public Transform startPos;
	public Transform endPos;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (startPos.position.x > endPos.position.x) {
			transform.position = transform.position + (Vector3.left * speed);
			if (transform.position.x < endPos.position.x)
				Reset();
		}
		else {
			transform.position = transform.position + (Vector3.right * speed);
			if (transform.position.x > endPos.position.x)
				Reset();
		}
    }
	
	private void Reset() {
		transform.position = startPos.position;
		speed = random.Next(minSpeed, maxSpeed) / 10f;
	}
}
