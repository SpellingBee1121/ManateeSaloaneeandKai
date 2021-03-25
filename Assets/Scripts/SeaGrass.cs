using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaGrass : MonoBehaviour
{
    public NeedsManager needs;

    public void Eat()
    {
        needs.Feed();
        gameObject.SetActive(false);

        // Optional: Play munching sound
    }
}
