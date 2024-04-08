using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ڵ� �ۼ�  -> �ڵ��� ����ü = �Լ� -> ���� �Լ��� ���� -> ������ �Լ��� ����ü = Ŭ���� -> ���� Ŭ������ ����ü = �����ӿ�ũ, ���ӽ����̽�(namespace)

// Ŭ����(class: ��ü�� ���赵): ���� �빮�ڷ� ����
// �ν��Ͻ�(instance: Ŭ������ ����� ���, ���� ���� Ŭ������ ����): ���� �ҹ��ڷ� ����

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
        InvokeRepeating("makeBall", 1.0f, 3.0f); // 1�� ����: �Լ��� ���ڿ�; 2�� ����: ���� �ð�(��); 3�� ����: �ݺ� �ֱ�(��)
    }

    // ���� ���� �Լ�: "makeBall"�� ���� �̸����� ����
    void makeBall()
    {
        // �ν��Ͻ�(instance) �����(instantiate)
        // ���� ���� ������Ʈ�� Transform�� ���� �ν��Ͻ��� transform
        // . �ǹ�: Ŭ������ ���(����, �Լ�)�� �����ϴ� ��ȣ
        Instantiate(ball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
