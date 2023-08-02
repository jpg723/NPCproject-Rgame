using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tori_start : MonoBehaviour, IPointerDownHandler
{
    public GameObject chuchu1;
    public GameObject chuchu2;
    public GameObject chuchu3;
    public GameObject tori;
    public Text ScriptText_dialogue;
    public Text ScriptText_name;
    public string[] dialogue
        = { "�丮�� �װ� �� usb ���� �� ������ �ôٴ��� �����̾�??",
            "�� �� ������ ����..",
            "�ʵ� �� �����ָ� ���� �� �����ٰ�",
            "�� �����ָ� �ɱ�??",
            "�� �翡 �ִ� ����� �ʹ� ���Ƽ� �� ������ �𸣰ھ�..!",
            "�׷� �Ŷ�� ��������! ���� ����� ������ �� ���ָ� �Ǵ� ����??",
            "���������� ������, Ȧ������ ¦�������� �˷��ָ� ��!",
            "�̹� ������ Ȧ¦ �����̾� �� �˰� ����??"
        };
    public int dialogue_count = 0;

    public void OnPointerDown(PointerEventData data)
    {
        dialogue_count++;
        Debug.Log(dialogue_count);

        if (dialogue_count == 8)
            SceneManager.LoadScene("tori_Game_Scene");

        ScriptText_dialogue.text = dialogue[dialogue_count];

        //���� �⺻ �̹��� Ȱ��ȭ
        if (dialogue_count == 0 || dialogue_count == 3)
        {
            chuchu1.SetActive(true);
            chuchu2.SetActive(false);
            chuchu3.SetActive(false);
            tori.SetActive(false);
            ScriptText_name.text = "����";
        }

        //���� ���� �̹��� Ȱ��ȭ
        else if (dialogue_count == 1)
        {
            chuchu1.SetActive(false);
            chuchu2.SetActive(true);
            chuchu3.SetActive(false);
            tori.SetActive(false);
            ScriptText_name.text = "����";
        }

        //���� ���� �̹��� Ȱ��ȭ
        else if (dialogue_count == 5)
        {
            chuchu1.SetActive(false);
            chuchu2.SetActive(false);
            chuchu3.SetActive(true);
            tori.SetActive(false);
            ScriptText_name.text = "����";
        }

        //�丮 �̹��� Ȱ��ȭ
        else if (dialogue_count == 2 || dialogue_count == 4 || dialogue_count == 6 || dialogue_count == 7)
        {
            chuchu1.SetActive(false);
            chuchu2.SetActive(false);
            chuchu3.SetActive(false);
            tori.SetActive(true);
            ScriptText_name.text = "�丮";
        }
    }
}