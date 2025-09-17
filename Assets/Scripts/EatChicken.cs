using UnityEngine;
using TMPro;

public class EatChicken : MonoBehaviour
{
    public TextMeshProUGUI gameText;
    private int eaten = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chicken")
        {
            eaten++;
            Destroy(other.gameObject);
            gameText.text = "Chickens eaten: " + eaten;
        }
    }
}
