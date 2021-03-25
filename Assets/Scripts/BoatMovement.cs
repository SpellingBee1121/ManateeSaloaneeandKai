using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
	private int time;
    private Vector3 curVel = new Vector3(0f, 0f, 0f);
	private System.Random random = new System.Random();
	public int minTime = 1;
	public int maxTime = 5;
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
        transform.position = Vector3.SmoothDamp(transform.position, endPos.position, ref curVel, time);

        if (Vector3.Distance(transform.position, endPos.position) <= 0.5)
        {
            Reset();
        }
    }
	
	private void Reset() {
		transform.position = startPos.position;
		time = random.Next(minTime, maxTime);
        curVel = new Vector3(0f, 0f, 0f);
	}
}
