using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNewScript : MonoBehaviour
{
    int i = 10;
    public GameObject MyCube;

    void Start()
    {
        string name = MyCube.name;
        print(name);
        print(i);
    }
}
