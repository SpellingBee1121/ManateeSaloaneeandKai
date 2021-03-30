using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedsManager : MonoBehaviour
{
    // Values for needs (public so I can watch them). Range from 0-1.
    public float air = 1f;
    public float food = 1f;
    public float social = 1f;

    //adding GUI

   // float airWindow = EditorGUI.IntSlider(new Rect(3, 3, position.width - 6, 15), "Air", Mathf.RoundToInt(air), 0, 100);
   // float foodWindow = EditorGUI.IntSlider(new Rect(3, 25, position.width - 6, 15), "Food", Mathf.RoundToInt(food), 0, 100);

   // public float airLoad = 

    // How long it takes for each need to go from 1 to 0.
    public float airTimer = 20f;
    public float foodTimer = 10f;
    public float socialTimer = 30f;

    // Used for interpolation calculations
    private float airVelocity = 0f;
    private float foodVelocity = 0f;
    private float socialVelocity = 0f;

    // Is the manatee breathing right now?
    private bool breathing = false;

    
    // Start is called before the first frame update

        
/*       static void Init()
    {
        NeedsManager window = GetWindow(typeof(EditorGUIProgressBar), false, "DisplayInfo");
        window.Show();
    }

  */
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

}
