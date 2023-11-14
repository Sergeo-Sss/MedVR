using UnityEngine;

public class WaterPast : MonoBehaviour
{
    public Material newmat;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trap")
        {
            other.gameObject.GetComponent<Renderer>().material = newmat;
        }
    }
}
