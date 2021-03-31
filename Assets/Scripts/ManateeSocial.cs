using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManateeSocial : MonoBehaviour
{
    private float movementSpeed = 5f;
    private GameObject heart;
    public NeedsManager needs;

    public AudioSource msound;
    //public Transform manateestartPos;
	//public Transform manateeendPos;
    

    // Start is called before the first frame update
    void Start()
    {
        heart = transform.Find("Heart").gameObject;
        msound =  GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Socialize()
    {
        needs.Socialize();
        heart.SetActive(true);
        StartCoroutine("HeartStop");
        msound.Play();
        
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

    }

    private IEnumerator HeartStop()
    {
        yield return new WaitForSeconds(3);
        heart.SetActive(false);
    }
}
