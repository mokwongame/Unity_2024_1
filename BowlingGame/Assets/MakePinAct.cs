using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePinAct : MonoBehaviour
{
    public GameObject pin;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        InvokeRepeating("makePin", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void makePin()
    {
        // Pin이 생성되는 위치를 무작위(Random 클래스 활용)로 설정
        Vector3 vector3 = new Vector3(); // C와 다르게 C#에서는 변수를 반드시 초기화(=)해서 써야 함; new는 새로운 인스턴스(클래스를 실행한 결과, 변수) 생성
        vector3.x = Random.Range(-8.5f, 8.5f); // 좌우
        vector3.y = Random.Range(3.0f, 10.0f); // 상하(높이)
        vector3.z = Random.Range(-5.0f, 10.0f); // 전후
        // transform은 현재 게임 오브젝트인 PinPosition이 실행된 Transform
        //Instantiate(pin, transform.position, transform.rotation);
        GameObject newPin = Instantiate(pin, vector3, transform.rotation); // 3차원의 무작위 위치는 vector3에 저장됨
        Renderer rend = newPin.GetComponent<Renderer>();
        rend.material.color = gameManager.getRandomColor();
    }
}
