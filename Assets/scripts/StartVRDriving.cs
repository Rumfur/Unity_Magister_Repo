using UnityEngine;

public class StartVRDriving : MonoBehaviour
{
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
            buttonReset.gameObject.SetActive(true);
            buttonFinish.gameObject.SetActive(true);
            buttonStart.gameObject.SetActive(false);
            startInfo.gameObject.SetActive(false);
        }
    }
}