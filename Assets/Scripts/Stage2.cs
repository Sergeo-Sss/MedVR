using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
    public Light firepoint;
    public TMP_Text text;

    public GameObject ideal_shina;
    public GameObject ideal_bondage;

    private int count;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "bondage_int" || other.gameObject.name == "shina_int")
        {
            firepoint.enabled = false;

            if(other.gameObject.name == "bondage_int")
                ideal_bondage.SetActive(true);
            else
                ideal_shina.SetActive(true);

            count++;
            Destroy(other.gameObject);
        }

        if(count == 2)
        {
            text.text = "У пациента перелом:\nЗадание пройдено!";
        }
    }
}