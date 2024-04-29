using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPinAct : MonoBehaviour
{
    GameManager gameManager;
    bool bHit = false; // 충돌 여부를 판단하는 변수

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 충돌(collision) 시작(enter)을 처리하는 함수(이벤트 핸들러, 이벤트 처리기): On으로 시작하는 충돌 처리 함수
    private void OnCollisionEnter(Collision collision)
    {
        // gameObject: Pin(나 자신)의 인스턴스
        // collision.gameObject: 충돌한 상대방의 인스턴스
        // 꼬리표(태그, tag)로 게임 오브젝트를 구별
        // 상대방 게임 오브젝트의 태그 이름 얻기
        string objName = collision.gameObject.tag; // string은 문자열(string) 클래스
        if (!bHit && objName == "Ball") // 충돌(bHit)이 아니고(!), 그리고(&&) 태그가 Ball인 게임 오브젝트와 충돌하면
        {
            bHit = true; ; // 충돌 했음
            print("hit"); // print()는 디버깅용 문자열 출력
            gameManager.incScore(); // 1점 증가
            print("score = " + gameManager.getScore()); // 디버깅용 득점 출력
        }
    }
}
