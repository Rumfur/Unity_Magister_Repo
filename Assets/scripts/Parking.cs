using UnityEngine;
using UnityEngine.UI; // Required for UI elements
using TMPro;


public class ParkingTrigger : MonoBehaviour
{
    public TMP_Text parkingStatusText; // Reference to the UI Text element
    public Collider colliderLF;
    public Collider colliderLR;
    public Collider colliderRF;
    public Collider colliderRR;

    public bool isLFActive = false;
    public bool isLRActive = false;
    public bool isRFActive = false;
    public bool isRRActive = false;

    private void Start()
    {
        // Optionally, initialize the text field
        parkingStatusText.text = "Searching";
    }

    // OnTriggerEnter to set boolean to true when collider is entered
    private void OnTriggerEnter(Collider other)
    {
        if (other == colliderLF)
        {
            isLFActive = true;
            Debug.Log("Left Front Collider Trigger Entered");
        }
        else if (other == colliderLR)
        {
            isLRActive = true;
            Debug.Log("Left Rear Collider Trigger Entered");
        }
        else if (other == colliderRF)
        {
            isRFActive = true;
            Debug.Log("Right Front Collider Trigger Entered");
        }
        else if (other == colliderRR)
        {
            isRRActive = true;
            Debug.Log("Right Rear Collider Trigger Entered");
        }
    }

    // OnTriggerExit to set boolean to false when collider is exited
    private void OnTriggerExit(Collider other)
    {
        if (other == colliderLF)
        {
            isLFActive = false;
            Debug.Log("Left Front Collider Trigger Exited");
        }
        else if (other == colliderLR)
        {
            isLRActive = false;
            Debug.Log("Left Rear Collider Trigger Exited");
        }
        else if (other == colliderRF)
        {
            isRFActive = false;
            Debug.Log("Right Front Collider Trigger Exited");
        }
        else if (other == colliderRR)
        {
            isRRActive = false;
            Debug.Log("Right Rear Collider Trigger Exited");
        }
    }
}
