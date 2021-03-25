using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMover : MonoBehaviour
{
    private float vel = 0f;
    private Vector3 target;
    internal bool moving = false;

    private void Start()
    {
        target = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target, 0.5f * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) <= 0.5)
        {
            moving = false;
        } 
    }

    public void Move(Vector3 movement)
    {
        target = movement;
        moving = true;
    }
}
