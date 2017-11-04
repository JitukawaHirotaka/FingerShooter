using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.0f;
    private GameObject player = null;
    private float angle = 0.0f;
    private Score score;

    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Score>();
        player = Player.GetPlayer();
    }

    void Update()
    {
        angle = Mathf.Atan2(transform.position.x - player.transform.position.x, transform.position.z - player.transform.position.z);
        transform.position -= new Vector3(Mathf.Sin(angle), 0.0f, Mathf.Cos(angle)) * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            score.Add(100);
            AudioManager.PlaySE("button");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
