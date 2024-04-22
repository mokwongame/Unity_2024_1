using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBallAct : MonoBehaviour
{
    float moveSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 좌우 방향 움직임의 입력(-1~+1); Time.deltaTime는 화면 리프레시 시간
        transform.Translate(xoff, 0.0f, 0.0f); // x축으로 xoff만큼 이동
    }
}
