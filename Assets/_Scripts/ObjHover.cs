using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class ObjHover : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 endPos; 

    void Start()
    {
        Tween.Position(transform, transform.position - endPos, 1.0f, Random.Range(0f, 2f), null, Tween.LoopType.PingPong);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
