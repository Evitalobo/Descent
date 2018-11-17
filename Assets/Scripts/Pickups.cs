using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour {
    [SerializeField]
    [Tooltip("Camera used by player")]
    private new Camera camera;
    [SerializeField]
    [Tooltip("Layer of items to be picked up")]
    private LayerMask layerMask;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo, 5f, layerMask))
            {
                hitInfo.collider.gameObject.SetActive(false);
            }
        }
	}
}
