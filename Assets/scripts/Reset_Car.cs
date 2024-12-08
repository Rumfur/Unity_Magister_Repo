using UnityEngine;

public class SetObjectPosition : MonoBehaviour
{
    public GameObject targetObject;
    public float x;
    public float y;
    public float z;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "KeyObject") {
            targetObject.transform.position = new Vector3(x, y, z);
            targetObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
