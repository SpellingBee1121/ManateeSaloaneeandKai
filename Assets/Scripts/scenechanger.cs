using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    public void scenechange(string scenename){
        SceneManager.LoadScene(scenename);
    }


}
