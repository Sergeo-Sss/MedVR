using UnityEngine;
using TMPro;
public class Stages : MonoBehaviour
{
    public Light firepoint;
    public GameObject idealtrap;
    public TMP_Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trap")
        {
            firepoint.enabled = false;
            other.gameObject.SetActive(false);
            idealtrap.SetActive(true);
            text.text = "У пациента ожог:\nЗадание пройдено!";
        }
    }
}
