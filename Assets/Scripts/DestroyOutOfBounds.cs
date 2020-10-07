using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float size = 30f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > size || transform.position.x < -size || transform.position.z > size ||
            transform.position.z < -size)
        {
            Destroy(gameObject);
            if (gameObject.tag == "Animal")
            {
                Debug.Log("Game Over");
            }
        }
    }
}
