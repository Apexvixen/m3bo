using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.CodeAnalysis;

public class restart : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        { 
            transform.position = new Vector3(-262.63f, 3.8f, -6.06f); 
        }

    }

}



