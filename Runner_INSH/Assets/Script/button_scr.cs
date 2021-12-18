using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_scr : MonoBehaviour
{
    bool Player_in_trigger = false; //переменная для хранения состояния входа игрока
    // Update is called once per frame
    void Update() //Каждый кадр
    {
        //если нажата клавиша Е и игрок внутри
        if (Input.GetKeyDown(KeyCode.E) && Player_in_trigger)
        {
            print("Все ок");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Игрок вошел
        Player_in_trigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        //Игрок вышел
        Player_in_trigger = false;
    }
}
