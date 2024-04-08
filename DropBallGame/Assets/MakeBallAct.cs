using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 코드 작성  -> 코드의 집합체 = 함수 -> 여러 함수를 관리 -> 변수와 함수의 집합체 = 클래스 -> 여러 클래스의 집합체 = 프레임워크, 네임스페이스(namespace)

// 클래스(class: 객체의 설계도): 보통 대문자로 시작
// 인스턴스(instance: 클래스가 실행된 결과, 쉽게 보면 클래스의 변수): 보통 소문자로 시작

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
        InvokeRepeating("makeBall", 1.0f, 3.0f); // 1번 변수: 함수명 문자열; 2번 변수: 시작 시간(초); 3번 변수: 반복 주기(초)
    }

    // 내가 만든 함수: "makeBall"과 같은 이름으로 정의
    void makeBall()
    {
        // 인스턴스(instance) 만들기(instantiate)
        // 현재 게임 오브젝트의 Transform이 만든 인스턴스가 transform
        // . 의미: 클래스의 멤버(변수, 함수)에 접근하는 기호
        Instantiate(ball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
