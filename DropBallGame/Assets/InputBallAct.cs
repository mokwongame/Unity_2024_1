using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBallAct : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 프레임마다 호출하는 함수; 프레임: 장면의 그림
    // Update is called once per frame
    void Update()
    {
        // 사용자 입력 기다리기
        if (Input.GetKeyDown(KeyCode.Space)) // 스페이스(Space)를 누르(KeyDown)면(if)
        {
            makeBall();
        }
    }

    void makeBall()
    {
        // 인스턴스(instance) 만들기(instantiate)
        // 현재 게임 오브젝트의 Transform이 만든 인스턴스가 transform
        // . 의미: 클래스의 멤버(변수, 함수)에 접근하는 기호
        Instantiate(ball, transform.position, transform.rotation);
    }

}
