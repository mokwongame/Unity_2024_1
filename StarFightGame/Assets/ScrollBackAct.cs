using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackAct : MonoBehaviour
{
    float speed = 5.0f; // 속도 = 거리/시간; 거리 = 속도*시간
    float backWidth = 19.2f * 1.15f; // 배경 사진의 폭
    float camWidth = 20.0f; // 카메라의 폭

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xoff = -speed * Time.deltaTime;
        transform.Translate(xoff, 0.0f, 0.0f);
        if (transform.position.x < -camWidth / 2.0f - backWidth / 2.0f) // 화면에서 사라지면(if)
        {
            transform.Translate(backWidth * 2.0f, 0.0f, 0.0f); // 현재 이미지를 이미지 2개의 폭만큼 앞(오른쪽)으로 이동
        }
    }
}
