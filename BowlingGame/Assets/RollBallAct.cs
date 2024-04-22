using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBallAct : MonoBehaviour
{
    float moveSpeed = 8.0f;
    float rollForce = 1000.0f;
    bool bRolling = false; // ���� ���������� Ȯ��
    Rigidbody rb; // ������ ��Ģ�� �����Ű�� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); // gameObject�� ���� ���� ���� ���� ������Ʈ
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // �¿� ���� �������� �Է�(-1~+1); Time.deltaTime�� ȭ�� �������� �ð�
        transform.Translate(xoff, 0.0f, 0.0f); // x������ xoff��ŭ �̵�
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
        // Vector3.forward: +z ����(����)
        rb.AddForce(Vector3.forward * rollForce * 10.0f); // ���� rigidbody�� ���� �߰�
    }
}
