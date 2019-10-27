using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour {

    // Use this for initialization
    void Start() {
        StartCoroutine(RePositionWithDelay());
    }

    private IEnumerator RePositionWithDelay()
    {
        while (true)
        {
            SetRandomPosition();
            yield return new WaitForSeconds(5);
        }
    }

    private void SetRandomPosition()
    {
        float x = UnityEngine.Random.Range(-5.0f, 5.0f);
        float z = UnityEngine.Random.Range(-5.0f, 5.0f);
        Debug.Log("x,z: " + x.ToString("F2") + ", " +
            z.ToString("F2"));
        transform.position = new Vector3(x, 0.0f, z);
    }
}
