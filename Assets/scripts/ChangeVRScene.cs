using UnityEngine;
using UnityEngine.SceneManagement;
public class SendToVRDriving : MonoBehaviour
{
    public string SceneName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "KeyBlock") {
            SceneManager.LoadSceneAsync(SceneName);
        }
    }
}
