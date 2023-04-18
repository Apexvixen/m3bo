using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;


public class rockill : MonoBehaviour
{
    public void Ded(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
