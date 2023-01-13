using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestTravel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(WaitThenTravel());
    }

    public void Travel()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator WaitThenTravel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
