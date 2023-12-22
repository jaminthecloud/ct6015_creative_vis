using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderMain : MonoBehaviour
{

    public void LoadSceneByName()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
