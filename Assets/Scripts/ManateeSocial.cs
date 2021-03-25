using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManateeSocial : MonoBehaviour
{
    private GameObject heart;
    public NeedsManager needs;

    // Start is called before the first frame update
    void Start()
    {
        heart = transform.Find("Heart").gameObject;
    }

    // Update is called once per frame
    public void Socialize()
    {
        needs.Socialize();
        heart.SetActive(true);
        StartCoroutine("HeartStop");
    }

    private IEnumerator HeartStop()
    {
        yield return new WaitForSeconds(3);
        heart.SetActive(false);
    }
}
