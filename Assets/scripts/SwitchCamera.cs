using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour {
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    private bool isThirdPerson = false;

    public void ShowThirdPersonView() {
        firstPersonCamera.enabled = false;
        thirdPersonCamera.enabled = true;
        isThirdPerson = true;
    }

    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
        isThirdPerson = false;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            if (isThirdPerson) {
                ShowFirstPersonView();
            } else {
                ShowThirdPersonView();
            }
        }
    }
}

