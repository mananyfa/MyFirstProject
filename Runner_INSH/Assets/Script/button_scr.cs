using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_scr : MonoBehaviour
{
    bool Player_in_trigger = false; //���������� ��� �������� ��������� ����� ������
    // Update is called once per frame
    void Update() //������ ����
    {
        //���� ������ ������� � � ����� ������
        if (Input.GetKeyDown(KeyCode.E) && Player_in_trigger)
        {
            print("��� ��");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //����� �����
        Player_in_trigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        //����� �����
        Player_in_trigger = false;
    }
}
