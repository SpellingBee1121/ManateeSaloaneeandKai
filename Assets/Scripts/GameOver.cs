using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public NeedsManager needs;
    public GameObject gameOverText;

    private void Start()
    {
        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.RoundToInt(needs.air*100) == 0 || Mathf.RoundToInt(needs.food*100) == 0 || Mathf.RoundToInt(needs.social*100) == 0)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameOverText.SetActive(true);
    }
}
