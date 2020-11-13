using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCreditsScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
