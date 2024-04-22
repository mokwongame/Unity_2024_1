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
        gameManager = FindAnyObjectByType<GameManager>(); // 현재 실행 중인 GameManager 오브젝트를 가져오기
    }

    // Update is called once per frame
    void Update()
    {
        // gameManager.canMakeBall(): 공을 만들 수 있는지 확인
        // &&: 논리에서 AND 기능
        if (gameManager.canMakeBall() && Input.GetKeyDown(KeyCode.Space))
        {
            makeBall();
            gameManager.setMakeBall(false); // 공을 만들 수 없게 함
        }
    }

    void makeBall()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
