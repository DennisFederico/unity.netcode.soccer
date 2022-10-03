using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    float moveSpeed = 7.5f;
    float rotationSpeed = 90f;

    //TODO Change this to the new event-oriented Input System
    void Update() {

        //if (!IsOwner) return;

        Vector3 moveDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) {
            moveDir += transform.forward;
        }
        if (Input.GetKey(KeyCode.S)) {
            moveDir -= transform.forward;
        }
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
        }
    }
}
