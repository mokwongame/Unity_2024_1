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

    // �����Ӹ��� ȣ���ϴ� �Լ�; ������: ����� �׸�
    // Update is called once per frame
    void Update()
    {
        // ����� �Է� ��ٸ���
        if (Input.GetKeyDown(KeyCode.Space)) // �����̽�(Space)�� ����(KeyDown)��(if)
        {
            makeBall();
        }
    }

    void makeBall()
    {
        // �ν��Ͻ�(instance) �����(instantiate)
        // ���� ���� ������Ʈ�� Transform�� ���� �ν��Ͻ��� transform
        // . �ǹ�: Ŭ������ ���(����, �Լ�)�� �����ϴ� ��ȣ
        Instantiate(ball, transform.position, transform.rotation);
    }

}
