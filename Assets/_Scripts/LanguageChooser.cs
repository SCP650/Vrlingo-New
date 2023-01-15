using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using TMPro;
using UnityEngine.SceneManagement;

public class LanguageChooser : MonoBehaviour
{
    //public TextMeshProUGUI teachingLangText;
    //public TextMeshProUGUI learningLangText;
    public TextMeshProUGUI profileTeachLT;
    public TextMeshProUGUI profileLearnLT;

    public GameObject turtle;

    private void Start()
    {
        turtle.SetActive(false);
        turtle.transform.localScale = Vector3.zero;
    }

    public void SetTeachingLanguage(string lang)
    {
        //teachingLangText.text = lang.ToString();
        profileTeachLT.text = lang.ToString();
    }

    public void SetLearningLanguage(string lang)
    {
        //learningLangText.text = "Teaching " + lang.ToString();
        profileLearnLT.text = lang.ToString();
    }

    public void SetRole(string lang)
    {
        if(profileLearnLT.text == lang.ToString())
        {
            // student 
            PlayerPrefs.SetInt("IsTeacher", 0);
            SceneManager.LoadScene(1);
        }
        else
        {
            //teacher
            PlayerPrefs.SetInt("IsTeacher", 1);
            SceneManager.LoadScene(1);
        }
    }

    public void SummonTheTurtle()
    {
        turtle.SetActive(true);
        Tween.LocalScale(turtle.transform, new Vector3(0.7f, 0.7f, 0.7f), 4f, 0f);
        Tween.LocalPosition(turtle.transform, new Vector3(0.507000029f, 0.0949999988f, 1.71599996f), 4f, 0f);
        
    }

}
