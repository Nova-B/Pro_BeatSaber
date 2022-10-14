using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
    private void Start()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 90);
    }
    public void PushStartBtn(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }
}
