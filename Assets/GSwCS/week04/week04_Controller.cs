using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week04_Controller : MonoBehaviour
{
    //GameObject MyCube // UI에 등장 안함, 숨기면 접근하지 못함.
    public GameObject MyCube; // UI에 등장
    Transform MyTransform;
    Animator Anim;

    void Start()
    {
        //MyCube = GameObject.Find("Cube");
        print($"MyCube의 이름은(.name) {MyCube.name}입니다.");
        print($"MyCube의 활성상태(.active)는 {MyCube.active}입니다.");
        MyCube.SetActive(true);
        print($"MyCube의 활성상태를 {MyCube.active}로 바꿨습니다(.SetActive(true)).");
        print($"MyCube의 태그(.tag) {MyCube.tag}입니다.");

        // transform
        MyTransform = MyCube.transform; // transform만 해당
        print(MyTransform);
        Vector3 MyPosition = MyTransform.position;
        print(MyPosition);
        print(MyPosition.x);

        // anim
        Anim = MyCube.GetComponent<Animator>(); // 다른 component를 불러올 땐 GetComponent를 사용해야한다.
        Anim.speed = 0;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Anim.speed = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Anim.speed = 0;
        }
    }
}