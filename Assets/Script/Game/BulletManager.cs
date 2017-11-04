using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet = null;
    [SerializeField]
    private float interval = 0.0f;
    private float timer = 0.0f;

    void Start()
    {
        timer = 0.0f;
    }

    void Update()
    {
        if (timer >= interval)
        {
            timer = 0.0f;
            Instantiate(bullet, transform.position, transform.rotation);
        }
        timer += Time.deltaTime;
    }
}
