using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sample_LoadScene : MonoBehaviour
{
    void OnMouseDown()
    {
        string name = gameObject.name;
        print(name);
        if(name == "Scene1")
        {
            SceneManager.LoadScene("Scene2");
        }
        if(name == "Scene2")
        {
            SceneManager.LoadScene("Scene1");
        }
    }
}
