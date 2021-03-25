using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaGrass : MonoBehaviour
{
    public NeedsManager needs;

    public void Eat()
    {
        needs.Feed();
        transform.Find("default").gameObject.SetActive(false);
        StartCoroutine("Regrow");
        // Optional: Play munching sound
    }

    private IEnumerator Regrow()
    {
        yield return new WaitForSeconds(2);
        transform.Find("default").gameObject.SetActive(true);
    }
}
