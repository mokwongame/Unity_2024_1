using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBallAct : MonoBehaviour
{
    float moveSpeed = 8.0f;
    float rollForce = 1000.0f;
    bool bRolling = false; // 공이 굴러가는지 확인
    Rigidbody rb; // 물리학 법칙을 적용시키는 컴포넌트
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        rb = gameObject.GetComponent<Rigidbody>(); // gameObject는 현재 실행 중인 게임 오브젝트
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 좌우 방향 움직임의 입력(-1~+1); Time.deltaTime는 화면 리프레시 시간
        transform.Translate(xoff, 0.0f, 0.0f); // x축으로 xoff만큼 이동
        if (!bRolling) // 공이 구르지(bRolling) 않다(!, not)면(if)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rollBall();
                bRolling = true;
            }
        }
        else // 그외(else): 공이 구르면 = else if (bRolling)
        {
            if (transform.position.y < -5.0f) // 현재 공의 Transform 변수(인스턴스)는 transform; 공의 높이가 -5보다 작으면
            {
                gameManager.setMakeBall(true);
                Destroy(gameObject); // 현재 공의 게임 오브젝트 gameObject를 파괴; 메모리 절약을 위해 꼭 호출
            }
        }
    }

    void rollBall()
    {
        // Vector3.forward: +z 방향(전방)
        rb.AddForce(Vector3.forward * rollForce * 10.0f); // 현재 rigidbody에 힘을 추가
        gameManager.playBallShot(); // 공을 굴리면 효과음 연주
    }
}
