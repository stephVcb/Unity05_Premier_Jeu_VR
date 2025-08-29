using Unity.VisualScripting;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    private string goodTag = "Good";
    [SerializeField]
    private string badTag = "Bad";

    [SerializeField]
    private GameObject greenCauldron;

    [SerializeField]
    private GameObject redCauldron;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(badTag))
        {
            ShowRed();
        }
        else
        {
            ShowGreen();
        }
    }

    void ShowGreen()
    {
        //if (greenCauldron) greenCauldron.SetActive(true);
        //if (redCauldron) redCauldron.SetActive(false);
        greenCauldron.SetActive(true);
        redCauldron.SetActive(false);
    }

    void ShowRed()
    {
        //if (redCauldron) redCauldron.SetActive(true);
        //if (greenCauldron) greenCauldron.SetActive(false);
        redCauldron.SetActive(true);
        greenCauldron.SetActive(false);
    }

}
