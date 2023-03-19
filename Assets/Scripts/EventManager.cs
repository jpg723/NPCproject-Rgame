using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject Success; //성공 이미지
    public GameObject Failure; //실패 이미지
    public GameObject Rabbit; //토끼 이미지
    private bool success_state; //성공이미지 활성화.비활성화 설정
    private bool failure_state; //실패이미지 활성화.비활성화 설정
    private bool rabbit_state; //토끼이미지 활성화.비활성화 설정
    public GameObject[] Carrot = new GameObject[12]; //당근이미지
    private bool carrot_state; //토끼이미지 활성화.비활성화 
    private int sum = 0; //당근 개수 합계

    void Start()
    {
        CarrotView();

        //성공.실패 이미지 비활성화
        success_state = false;
        failure_state = false;
        //토끼 이미지 활성화
        rabbit_state = true;
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        Rabbit.SetActive(rabbit_state);
    }

    //당근 랜덤 출현
    void CarrotView()
    {
        int i = 0;
        int carrotStateNum; //당근 활성.비활성화 랜덤 결정 정수
        carrot_state = false;

        //당근 초기화(비활성화)
        for (i = 0; i < 12; i++)
            Carrot[i].SetActive(carrot_state);

        //합계 초기화
        sum = 0;

        for (i = 0; i < 12; i++)
        {
            //당근 랜덤으로 활성.비활성화 결정
            carrotStateNum = Random.Range(0, 2);

            //carrotStateNum이 1이면 활성화
            if (carrotStateNum == 1)
                carrot_state = true;

            //0이면 비활성화
            else
                carrot_state = false;

            //당근 활성.비활성화
            Carrot[i].SetActive(carrot_state);
            //활성화된 당근 개수
            sum += carrotStateNum;
        }

        //콘솔 결과 확인
        Debug.Log("sum: " +  sum);
    }


    //짝수 버튼 클릭 시
    public void EvenButtonClick()
    {
        //당근 개수가 짝수라면
        if (sum % 2 == 0)
        {
            success_state = true;
            failure_state = false;
        }

        //당근 개수가 홀수라면
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
        //당근 개수가 홀수라면
        if (sum % 2 != 0)
        {
            success_state = true;
            failure_state = false;
        }

        //당근 개수가 짝수라면
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


}