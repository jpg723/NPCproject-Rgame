using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private int randomNum;
    public GameObject Success; //성공 이미지
    public GameObject Failure; //실패 이미지
    public GameObject Rabbit; //토끼 이미지
    private bool success_state; //성공이미지 활성화.비활성화 설정
    private bool failure_state; //실패이미지 활성화.비활성화 설정
    private bool rabbit_state; //토끼이미지 활성화.비활성화 설정

    void Start()
    {
        //랜덤 숫자 생성
        randomNum = Random.Range(0, 12);
        Debug.Log(randomNum);

        //성공.실패 이미지 비활성화
        success_state = false;
        failure_state = false;
        //토끼 이미지 활성화
        rabbit_state = true;
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        Rabbit.SetActive(rabbit_state);
    }

    //짝수 버튼 클릭 시
    public void EvenButtonClick()
    {
        if (randomNum % 2 == 0)
        {
            success_state = true;
            failure_state = false;
        }

        else
        {
            success_state = false;
            failure_state = true;
        }

        //성공.실패 이미지 출력
        rabbit_state = false;
        Rabbit.SetActive(rabbit_state);
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        //콘솔 결과 확인
        Debug.Log("success_state: " + success_state + " / failure_state: " + failure_state);
        //랜덤 숫자 재생성 및 토끼 이미지 출력
        Invoke("Start", 3);
    }

    //홀수 버튼 클릭 시
    public void OddButtonClick()
    {
        if (randomNum % 2 != 0)
        {
            success_state = true;
            failure_state = false;
        }

        else
        {
            success_state = false;
            failure_state = true;
        }

        //성공.실패 이미지 출력
        rabbit_state = false;
        Rabbit.SetActive(rabbit_state);
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        //콘솔 결과 확인
        Debug.Log("success_state: " + success_state + " / failure_state: " + failure_state);
        //랜덤 숫자 재생성 및 토끼 이미지 출력
        Invoke("Start", 3);
    }
    /*
    void CarrotPrint(bool cs)
    {
        Carrot1.SetActive(cs);
        Carrot2.SetActive(cs);
        Carrot3.SetActive(cs);
        Carrot4.SetActive(cs);
        Carrot5.SetActive(cs);
        Carrot6.SetActive(cs);
        Carrot7.SetActive(cs);
        Carrot8.SetActive(cs);
        Carrot9.SetActive(cs);
        Carrot10.SetActive(cs);
        Carrot11.SetActive(cs);
        Carrot12.SetActive(cs);
    }

    //랜덤 당근 생성
    bool CarrotState()
    {
        bool c_state; //당근 이미지 활성화.비활성화 상태
        int carrot_state_num; //당근 활성화.비활성화 설정 
        carrot_state_num = Random.Range(0, 2); //0 또는 1출력

        if (carrot_state_num == 1)
        {
            c_state = true;
        }

        else
            c_state = false;

        return c_state;
    }
    */
}