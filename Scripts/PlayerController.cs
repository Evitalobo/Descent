using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 15.0f;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        float moveForwardBack = Input.GetAxis("Vertical") * moveSpeed;
        float moveToSide = Input.GetAxis("Horizontal") * moveSpeed;
        moveForwardBack *= Time.deltaTime;
        moveToSide *= Time.deltaTime;
        transform.Translate(moveToSide, 0, moveForwardBack);
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
	}
}
