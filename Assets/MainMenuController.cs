using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartInterview()
    {
        SceneManager.LoadScene("InterviewScene");
    }
}
