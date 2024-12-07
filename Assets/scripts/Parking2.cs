using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Parking2 : MonoBehaviour
{

    public Collider boxCollider;

    public Button button;  

    public TMP_Text parkingStatusText;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player_Vehicle") {
            parkingStatusText.text = "Parking";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Player_Vehicle") {
            Debug.Log("Trigger Staying");
            Vector3 boxCenter = boxCollider.bounds.center;
            float distanceToCenter = Vector3.Distance(boxCenter, other.transform.position);

            if (distanceToCenter < 1f)
            {
                Debug.Log("Player is at the center of the boxCollider");

                // Check the angle difference
                float angleDifference = Vector3.Angle(boxCollider.transform.forward, other.transform.forward);

                if ((angleDifference >= 0f && angleDifference <= 5f) || (angleDifference >= 175f && angleDifference <= 185f))
                {
                    Debug.Log("Player is centered");
                    parkingStatusText.text = "Parked";
                    button.gameObject.SetActive(true);
                } else {
                    button.gameObject.SetActive(false);
                    parkingStatusText.text = "Parking";
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player_Vehicle") {
            parkingStatusText.text = "Searching";
            button.gameObject.SetActive(false);
        }
    }
}
