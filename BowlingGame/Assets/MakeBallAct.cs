using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBallAct : MonoBehaviour
{
    public GameObject ball;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>(); // ���� ���� ���� GameManager ������Ʈ�� ��������
    }

    // Update is called once per frame
    void Update()
    {
        // gameManager.canMakeBall(): ���� ���� �� �ִ��� Ȯ��
        // &&: ������ AND ���
        if (gameManager.canMakeBall() && Input.GetKeyDown(KeyCode.Space))
        {
            makeBall();
            gameManager.setMakeBall(false); // ���� ���� �� ���� ��
        }
    }

    void makeBall()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
