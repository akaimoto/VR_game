using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker{
	
	// Update is called once per frame
	public bool clicked() {
        return Input.anyKeyDown;
	}
}
