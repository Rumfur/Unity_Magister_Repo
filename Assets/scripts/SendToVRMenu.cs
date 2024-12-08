using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class SendToVRMenu : MonoBehaviour
{
    public TMP_Text parkingStatusText;
    public TMP_Text warningText;

    public GameObject targetObject;
    public GameObject buttonReset;
    public GameObject buttonFinish;
    public GameObject buttonStart;
    public GameObject startInfo;
    public float x;
    public float y;
    public float z;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "KeyObject") {
            targetObject.transform.position = new Vector3(x, y, z);
            targetObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        // if (other.name == "KeyObject") {
        //     warningText.text = "Parked";
        //     buttonReset.gameObject.SetActive(false);
        //     buttonFinish.gameObject.SetActive(false);
        //     buttonStart.gameObject.SetActive(true);
        //     startInfo.gameObject.SetActive(true);
        //     targetObject.transform.position = new Vector3(x, y, z);
        //     targetObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        //     if (parkingStatusText.text == "Parked") {
        //         warningText.text = "Parked";
        //         buttonReset.gameObject.SetActive(false);
        //         buttonFinish.gameObject.SetActive(false);
        //         buttonStart.gameObject.SetActive(true);
        //         startInfo.gameObject.SetActive(true);
        //         targetObject.transform.position = new Vector3(x, y, z);
        //         targetObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        //     } else {
        //         warningText.text = "CORRECTLY PARK IN A PARKING SPOT TO FINISH. Status:" + parkingStatusText.text;
        //     }
        // }
    }

    private void OnTriggerExit(Collider other)
    {
        warningText.text = "";
    }
}
