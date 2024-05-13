using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeBallAct : MonoBehaviour
{
    public GameObject ball;
    GameManager gameManager;
    int colorIndex = 0;
    Renderer rendBall = null; // 생성한 공의 Renderer 인스턴스

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
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            colorIndex++;
            if (colorIndex >= gameManager.getColorSize()) colorIndex = 0;
            // 공이 생기지 않은 경우(rendBall이 null)는 색깔 변경 생략
            if (rendBall != null) rendBall.material.color = gameManager.getColor(colorIndex);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            colorIndex--;
            //if (colorIndex < 0) colorIndex = 7;
            if (colorIndex < 0) colorIndex = gameManager.getColorSize() - 1;
            // 공이 생기지 않은 경우(rendBall이 null)는 색깔 변경 생략
            if (rendBall != null) rendBall.material.color = gameManager.getColor(colorIndex);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("EndGame");
        }
    }

    void makeBall()
    {
        GameObject newBall = Instantiate(ball, transform.position, transform.rotation);
        rendBall = newBall.GetComponent<Renderer>();
        rendBall.material.color = gameManager.getColor(colorIndex);
    }
}
