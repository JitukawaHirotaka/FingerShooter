using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingObject : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float rate;

	void Start ()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
	}
	
	void Update ()
    {
        transform.position = Vector3.Lerp(new Vector3(target.position.x, transform.position.y, target.position.z), transform.position, rate);
    }
}
