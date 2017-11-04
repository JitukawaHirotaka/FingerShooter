using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float Speed = 0.0f;
    private float rot = 0.0f;

    void Start()
    {
        rot = ((180.0f - transform.eulerAngles.y) / 180.0f) * Mathf.PI - (Mathf.PI * 0.5f);
    }
    
    void Update()
    {
        transform.position += new Vector3(Mathf.Cos(rot) * Speed, 0.0f, Mathf.Sin(rot) * Speed);
    }
}
