using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week04_Controller : MonoBehaviour
{
    public GameObject MyCube;
    Transform MyTransform;
    Animator Anim;
    void Start()
    {
        //MyCube = GameObject.Find("Cube");
        print($"MyCube의 이름은(.name) {MyCube.name}입니다.");
        print($"MyCube의 활성상태(.active)는 {MyCube.activeSelf}입니다.");
        MyCube.SetActive(true);
        print($"MyCube의 활성상태를 {MyCube.activeSelf}로 바꿨습니다(.SetActive(true)).");
        print($"MyCube의 태그(.tag) {MyCube.tag}입니다.");

        MyTransform = MyCube.transform;
        print(MyTransform);
        Vector3 MyPosition = MyTransform.position;
        print(MyPosition);
        print(MyPosition.x);

        Anim = MyCube.GetComponent<Animator>();
        Anim.speed = 0;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Anim.speed = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Anim.speed = 0;
        }
    }
}
