using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookWalk : MonoBehaviour {
    public float velocity = 0.7f;
	// Update is called once per frame
	void Update () {
        Vector3 moveDirection = Camera.main.transform.forward;
        moveDirection *= velocity * Time.deltaTime;
        moveDirection.y = 0.0f;
        transform.position += moveDirection; 
	
	}
}
