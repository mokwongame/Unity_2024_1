using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameAct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("startGame", 5.0f); // 5�� �ڿ� startGame() �Լ� ȣ��
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startGame()
    {
        SceneManager.LoadScene("BowlingGame"); // ���� ���� BowlingGame���� ����
    }
}
