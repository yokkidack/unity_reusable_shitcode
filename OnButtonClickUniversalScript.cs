using UnityEngine;
using UnityEngine.SceneManagement;

public class OnButtonClickUniversalScript : MonoBehaviour
{
    [SerializeField]
    private
    string WhatSceneToLoad;

    public void LoadDefinedScene()
    {
        SceneManager.LoadScene(WhatSceneToLoad);
    }
}
