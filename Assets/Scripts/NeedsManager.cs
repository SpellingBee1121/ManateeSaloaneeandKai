using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NeedsManager : MonoBehaviour
{
    // Values for needs (public so I can watch them). Range from 0-1.
    public float air = 1f;
    public float food = 1f;
    public float social = 1f;

    // How long it takes for each need to go from 1 to 0. Not working in terms of seconds right now but it's fine.
    public float airTimer = 20f;
    public float foodTimer = 10f;
    public float socialTimer = 30f;
	
	// Text display for needs
	public TextMeshPro airCounter;
	public TextMeshPro foodCounter;
	public TextMeshPro socialCounter;

    // Used for interpolation calculations
    private float airVelocity = 0f;
    private float foodVelocity = 0f;
    private float socialVelocity = 0f;

    // Is the manatee breathing right now?
    private bool breathing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (breathing)
        {
            air = 1f;
        }
        else
        {
            air = Mathf.SmoothDamp(air, 0f, ref airVelocity, airTimer);
        }
        
        food = Mathf.SmoothDamp(food, 0f, ref foodVelocity, foodTimer);
        social = Mathf.SmoothDamp(social, 0f, ref socialVelocity, socialTimer);
		
		UpdateText();
    }

    public void Feed()
    {
        food += 0.5f;
        food = Mathf.Clamp(food, 0f, 1f);
    }

    public void SetBreathing(bool breathe)
    {
        breathing = breathe;
    }

    public void Socialize()
    {
        social += 0.2f;
        social = Mathf.Clamp(social, 0f, 1f);
    }
	
	private void UpdateText() 
	{
		airCounter.text = (Mathf.RoundToInt(air * 100)).ToString() + "%";
		foodCounter.text = (Mathf.RoundToInt(food * 100)).ToString() + "%";
		socialCounter.text = (Mathf.RoundToInt(social * 100)).ToString() + "%";
	}
}
