using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPinAct : MonoBehaviour
{
    GameManager gameManager;
    bool bHit = false; // �浹 ���θ� �Ǵ��ϴ� ����

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // �浹(collision) ����(enter)�� ó���ϴ� �Լ�(�̺�Ʈ �ڵ鷯, �̺�Ʈ ó����): On���� �����ϴ� �浹 ó�� �Լ�
    private void OnCollisionEnter(Collision collision)
    {
        // gameObject: Pin(�� �ڽ�)�� �ν��Ͻ�
        // collision.gameObject: �浹�� ������ �ν��Ͻ�
        // ����ǥ(�±�, tag)�� ���� ������Ʈ�� ����
        // ���� ���� ������Ʈ�� �±� �̸� ���
        string objName = collision.gameObject.tag; // string�� ���ڿ�(string) Ŭ����
        if (!bHit && objName == "Ball") // �浹(bHit)�� �ƴϰ�(!), �׸���(&&) �±װ� Ball�� ���� ������Ʈ�� �浹�ϸ�
        {
            bHit = true; ; // �浹 ����
            print("hit"); // print()�� ������ ���ڿ� ���
            gameManager.incScore(); // 1�� ����
            print("score = " + gameManager.getScore()); // ������ ���� ���
        }
    }
}
