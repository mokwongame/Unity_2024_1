using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBallAct : MonoBehaviour
{
    public GameObject ball;
    public GameObject cubeColor;
    Renderer cubeRend;
    // red, green, blue, white, black 순으로 색깔 변화
    int colorSize = 5; // 색깔 개수
    int colorIndex = 0; // 현재 색깔 위치: 0, 1, 2, 3, 4(=5-1)

    // Start is called before the first frame update
    void Start()
    {
        cubeRend = cubeColor.GetComponent<Renderer>(); // 오브젝트 cubeColor의 컴포넌트(Component)에 접근해서 Renderer를 반환
        cubeRend.material.color = Color.red;
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
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) // 왼쪽 화살표: 색깔이 역순으로 변경
        {
            colorIndex--; // colorIndex = colorIndex - 1
            if (colorIndex < 0) colorIndex = colorSize - 1; // 0보다 작으면 4로 설정
            cubeRend.material.color = getColor();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) // 오른쪽 화살표: 색깔이 정상적으로 변경
        {
            colorIndex++; // colorIndex = colorIndex + 1
            if (colorIndex >= colorSize) colorIndex = 0; // 5보다 크거나 같으면 0으로 설정
            cubeRend.material.color = getColor();
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) // 이스케이프 키 눌러서 게임 종료
        {
            Application.Quit(); // 게임 앱(app, application)을 종료(quit)
        }
    }

    void makeBall()
    {
        // 인스턴스(instance) 만들기(instantiate)
        // 현재 게임 오브젝트의 Transform이 만든 인스턴스가 transform
        // . 의미: 클래스의 멤버(변수, 함수)에 접근하는 기호
        GameObject newBall = Instantiate(ball, transform.position, transform.rotation); // 공을 생성(Instantiate)해서 GameObject인 newBall을 초기화(=)
        Renderer renderer = newBall.GetComponent<Renderer>();
        renderer.material.color = getColor();
    }

    Color getColor()
    {
        // switch 구문은 if, else 구문을 간소화시킴
        switch (colorIndex)
        {
            case 0: return Color.red; // if (colorIndex == 0) {...}
            case 1: return Color.green;
            case 2: return Color.blue;
            case 3: return Color.white;
            case 4: return Color.black;
            default: return Color.black;
        }
    }
}
