using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Trigger started");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");
    }
}
