using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스 정의: class 클래스명 {...변수, 함수 집합...}
public class MakeBallAct : MonoBehaviour
{
    // 변수 선언: 유니티 에디터의 오브젝트에 접근
    public GameObject ball; // GameObject 자료형(클래스)이며 이름은 ball로 가진 변수 선언
    // public 의미: 외부에서 변수에 접근을 허락

    // Start is called before the first frame update
    void Start() // 함수 정의: 함수명 {...코드 집합...}
    {
        // 반복해서(repeating) 시작(invoke)
        InvokeRepeating("makeBall", 1.0f, 2.0f); // 1번 변수: 함수명 문자열; 2번 변수: 시작 시간(초); 3번 변수: 반복 주기(초)
    }

    // 내가 만든 함수: "makeBall"과 같은 이름으로 정의
    void makeBall()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
