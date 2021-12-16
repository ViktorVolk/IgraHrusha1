using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFood : MonoBehaviour
{
    private float[] FoodSpeed = {3f, 2.5f, 1f, 5f };
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * FoodSpeed[Random.Range(0,4)] * Time.deltaTime);

        if (transform.position.x > 5)
            Destroy(gameObject);
    }
}
