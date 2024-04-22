using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBallAct : MonoBehaviour
{
    float moveSpeed = 8.0f;
    float rollForce = 1000.0f;
    bool bRolling = false; // 공이 굴러가는지 확인
    Rigidbody rb; // 물리학 법칙을 적용시키는 컴포넌트

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); // gameObject는 현재 실행 중인 게임 오브젝트
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 좌우 방향 움직임의 입력(-1~+1); Time.deltaTime는 화면 리프레시 시간
        transform.Translate(xoff, 0.0f, 0.0f); // x축으로 xoff만큼 이동
        if (!bRolling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rollBall();
                bRolling = true;
            }
        }
    }

    void rollBall()
    {
        // Vector3.forward: +z 방향(전방)
        rb.AddForce(Vector3.forward * rollForce * 10.0f); // 현재 rigidbody에 힘을 추가
    }
}
