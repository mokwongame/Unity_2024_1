using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameAct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("BowlingGame");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Application.Quit(); // 게임을 완전 종료
        }
    }
}
