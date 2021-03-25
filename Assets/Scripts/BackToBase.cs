using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToBase : MonoBehaviour
{
    public StageMover mover;
    public NeedsManager needs;

    public void GoHome()
    {
        mover.Move(new Vector3(0f, 0f, 0f));
        needs.SetBreathing(false);
    }
}
