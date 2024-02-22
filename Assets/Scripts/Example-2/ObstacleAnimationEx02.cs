using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimationEx02 : MonoBehaviour
{
    public float speed = .2f;
    public float strength = 9f;

    private float randomOffset;

    // Initialization random speed offset
    private void Start()
    {
        randomOffset = Random.Range(0f, 4f);
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        pos.z = Mathf.Sin(Time.time * speed + randomOffset) * strength;
        transform.position = pos;
    }
}
