using UnityEngine;

public class SetObjectPosition : MonoBehaviour
{
    public GameObject targetObject;
    public float x;
    public float y;
    public float z;

        private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ButtonReset") {
            targetObject.transform.position = new Vector3(x, y, z);
        }
        if (other.name == "ButtonFinish") {
            targetObject.transform.position = new Vector3(0, 50, 0);
        }
    }
}
