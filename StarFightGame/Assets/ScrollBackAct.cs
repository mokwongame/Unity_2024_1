using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackAct : MonoBehaviour
{
    float speed = 5.0f; // �ӵ� = �Ÿ�/�ð�; �Ÿ� = �ӵ�*�ð�
    float backWidth = 19.2f * 1.15f; // ��� ������ ��
    float camWidth = 20.0f; // ī�޶��� ��

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xoff = -speed * Time.deltaTime;
        transform.Translate(xoff, 0.0f, 0.0f);
        if (transform.position.x < -camWidth / 2.0f - backWidth / 2.0f) // ȭ�鿡�� �������(if)
        {
            transform.Translate(backWidth * 2.0f, 0.0f, 0.0f); // ���� �̹����� �̹��� 2���� ����ŭ ��(������)���� �̵�
        }
    }
}
