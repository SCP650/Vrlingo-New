using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using TMPro;

public class LanguageChooser : MonoBehaviour
{
    public TextMeshProUGUI teachingLangText;
    public TextMeshProUGUI learningLangText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTeachingLanguage(string lang)
    {
        teachingLangText.text = lang.ToString();
    }

    public void SetLearningLanguage(string lang)
    {
        learningLangText.text = lang.ToString();
    }


}
