using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using TMPro;

public class LanguageChooser : MonoBehaviour
{
    public TextMeshProUGUI teachingLangText;
    public TextMeshProUGUI learningLangText;
    public TextMeshProUGUI profileTeachLT;
    public TextMeshProUGUI profileLearnLT;


    public void SetTeachingLanguage(string lang)
    {
        teachingLangText.text = lang.ToString();
        profileTeachLT.text = lang.ToString();
    }

    public void SetLearningLanguage(string lang)
    {
        learningLangText.text = "Teaching " + lang.ToString();
        profileLearnLT.text = "Learning " + lang.ToString();
    }

}
