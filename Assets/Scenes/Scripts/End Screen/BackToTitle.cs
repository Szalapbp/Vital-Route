using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    public string backToTitle;

    public void LoadTitle()
    {
        SceneManager.LoadScene(backToTitle);
    }
}
