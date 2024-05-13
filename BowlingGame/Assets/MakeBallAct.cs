using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeBallAct : MonoBehaviour
{
    public GameObject ball;
    GameManager gameManager;
    int colorIndex = 0;
    Renderer rendBall = null; // ������ ���� Renderer �ν��Ͻ�

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
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            colorIndex++;
            if (colorIndex >= gameManager.getColorSize()) colorIndex = 0;
            // ���� ������ ���� ���(rendBall�� null)�� ���� ���� ����
            if (rendBall != null) rendBall.material.color = gameManager.getColor(colorIndex);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            colorIndex--;
            //if (colorIndex < 0) colorIndex = 7;
            if (colorIndex < 0) colorIndex = gameManager.getColorSize() - 1;
            // ���� ������ ���� ���(rendBall�� null)�� ���� ���� ����
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
