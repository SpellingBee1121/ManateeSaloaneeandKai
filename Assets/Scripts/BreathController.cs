using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathController : MonoBehaviour
{
    public StageMover mover;
    public float waterHeight;
    public NeedsManager needs;

    private bool waiting = false;

    public void GoUp()
    {
        mover.Move(Vector3.down * waterHeight);
        waiting = true;
    }

    private void Update()
    {
        if (waiting && mover.moving == false)
        {
            waiting = false;
            needs.SetBreathing(true);
        }
    }
}
