using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderBigBang : MonoBehaviour
{

    public void LoadSceneByName()
    {
        SceneManager.LoadScene("Big bang");
    }
}
