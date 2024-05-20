using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBallAct : MonoBehaviour
{
    float moveSpeed = 8.0f;
    float rollForce = 1000.0f;
    bool bRolling = false; // ���� ���������� Ȯ��
    Rigidbody rb; // ������ ��Ģ�� �����Ű�� ������Ʈ
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        rb = gameObject.GetComponent<Rigidbody>(); // gameObject�� ���� ���� ���� ���� ������Ʈ
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // �¿� ���� �������� �Է�(-1~+1); Time.deltaTime�� ȭ�� �������� �ð�
        transform.Translate(xoff, 0.0f, 0.0f); // x������ xoff��ŭ �̵�
        if (!bRolling) // ���� ������(bRolling) �ʴ�(!, not)��(if)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rollBall();
                bRolling = true;
            }
        }
        else // �׿�(else): ���� ������ = else if (bRolling)
        {
            if (transform.position.y < -5.0f) // ���� ���� Transform ����(�ν��Ͻ�)�� transform; ���� ���̰� -5���� ������
            {
                gameManager.setMakeBall(true);
                Destroy(gameObject); // ���� ���� ���� ������Ʈ gameObject�� �ı�; �޸� ������ ���� �� ȣ��
            }
        }
    }

    void rollBall()
    {
        // Vector3.forward: +z ����(����)
        rb.AddForce(Vector3.forward * rollForce * 10.0f); // ���� rigidbody�� ���� �߰�
        gameManager.playBallShot(); // ���� ������ ȿ���� ����
    }
}
