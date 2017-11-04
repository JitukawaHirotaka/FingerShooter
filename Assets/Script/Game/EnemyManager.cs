using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player = null;
    [SerializeField]
    private List<GameObject> enemy = null;
    [SerializeField]
    private float interval = 0.0f;
    [SerializeField]
    private float radius = 0.0f;
    [SerializeField]
    private float rotSpeed = 0.0f;

    private float rot = 0;
    private float timer = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= interval)
        {
            timer = 0;
            GameObject obj = Instantiate(enemy[Random.Range(0, enemy.Count)], new Vector3(Mathf.Sin(rot) * radius, transform.position.y, Mathf.Cos(rot) * radius), Quaternion.identity);
            obj.transform.position += player.transform.position;
        }

        timer += Time.deltaTime;
        rot += rotSpeed;

        if (Mathf.PI * 2 <= rot) rot -= Mathf.PI * 2;
        else if (-Mathf.PI * 2 >= rot) rot += Mathf.PI * 2;
    }
}
