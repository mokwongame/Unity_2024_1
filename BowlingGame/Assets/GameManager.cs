using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool bCanMakeBall = true; // 공을 만들 수 있는 상태

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 공 만들 수 있는지 확인
    public bool canMakeBall() { return bCanMakeBall; }

    public void setMakeBall(bool bCanMake) // 공 만들기 상태 변경
    {
        bCanMakeBall = bCanMake;
    }
}
