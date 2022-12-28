using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30f;
    [SerializeField] private float lowerBound = -10f;
    void Update()
    {
        if (transform.position.z > topBound) { Destroy(gameObject); }
        else if (transform.position.z < lowerBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject); }
    }

    //update lives
}
