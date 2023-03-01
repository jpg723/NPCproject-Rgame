using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private int randomNum;
    public GameObject Success; //���� �̹���
    public GameObject Failure; //���� �̹���
    public GameObject Rabbit; //�䳢 �̹���
    private bool success_state; //�����̹��� Ȱ��ȭ.��Ȱ��ȭ ����
    private bool failure_state; //�����̹��� Ȱ��ȭ.��Ȱ��ȭ ����
    private bool rabbit_state; //�䳢�̹��� Ȱ��ȭ.��Ȱ��ȭ ����

    void Start()
    {
        //���� ���� ����
        randomNum = Random.Range(0, 12);
        Debug.Log(randomNum);

        //����.���� �̹��� ��Ȱ��ȭ
        success_state = false;
        failure_state = false;
        //�䳢 �̹��� Ȱ��ȭ
        rabbit_state = true;
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        Rabbit.SetActive(rabbit_state);
    }

    //¦�� ��ư Ŭ�� ��
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

        //����.���� �̹��� ���
        rabbit_state = false;
        Rabbit.SetActive(rabbit_state);
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        //�ܼ� ��� Ȯ��
        Debug.Log("success_state: " + success_state + " / failure_state: " + failure_state);
        //���� ���� ����� �� �䳢 �̹��� ���
        Invoke("Start", 3);
    }

    //Ȧ�� ��ư Ŭ�� ��
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

        //����.���� �̹��� ���
        rabbit_state = false;
        Rabbit.SetActive(rabbit_state);
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        //�ܼ� ��� Ȯ��
        Debug.Log("success_state: " + success_state + " / failure_state: " + failure_state);
        //���� ���� ����� �� �䳢 �̹��� ���
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

    //���� ��� ����
    bool CarrotState()
    {
        bool c_state; //��� �̹��� Ȱ��ȭ.��Ȱ��ȭ ����
        int carrot_state_num; //��� Ȱ��ȭ.��Ȱ��ȭ ���� 
        carrot_state_num = Random.Range(0, 2); //0 �Ǵ� 1���

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