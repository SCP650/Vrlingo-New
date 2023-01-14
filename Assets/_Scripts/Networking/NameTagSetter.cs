using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NameTagSetter : MonoBehaviour
{
    public void SetAsTeacher()
    {
        PlayerPrefs.SetInt("IsTeacher", 1);
        SceneManager.LoadScene(1);
    }

    public void SetAsStudent()
    {
        PlayerPrefs.SetInt("IsTeacher", 0);
        SceneManager.LoadScene(1);
    }
}
