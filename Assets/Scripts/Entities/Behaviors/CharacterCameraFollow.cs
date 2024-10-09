using System;
using UnityEngine;

public class CharacterCameraFollow : MonoBehaviour {
    private Camera mainCamera;

    private void Start () {
        mainCamera = Camera.main;
    }

    private void Update () {
        UpdateCameraPosition();
    }

    private void UpdateCameraPosition () {
        Vector3 objPos = transform.position;
        Vector3 cameraPos = mainCamera.transform.position;
        cameraPos.x = objPos.x;
        cameraPos.y = objPos.y;
        mainCamera.transform.position = cameraPos;
    }
}