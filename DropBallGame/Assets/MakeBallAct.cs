using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ŭ���� ����: class Ŭ������ {...����, �Լ� ����...}
public class MakeBallAct : MonoBehaviour
{
    // ���� ����: ����Ƽ �������� ������Ʈ�� ����
    public GameObject ball; // GameObject �ڷ���(Ŭ����)�̸� �̸��� ball�� ���� ���� ����
    // public �ǹ�: �ܺο��� ������ ������ ���

    // Start is called before the first frame update
    void Start() // �Լ� ����: �Լ��� {...�ڵ� ����...}
    {
        // �ݺ��ؼ�(repeating) ����(invoke)
        InvokeRepeating("makeBall", 1.0f, 2.0f); // 1�� ����: �Լ��� ���ڿ�; 2�� ����: ���� �ð�(��); 3�� ����: �ݺ� �ֱ�(��)
    }

    // ���� ���� �Լ�: "makeBall"�� ���� �̸����� ����
    void makeBall()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
