using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour
{
    public Vector2 Area
    {
        get { return area; }
    }

    [SerializeField]
    private Vector2 area;

    [SerializeField]
    private Material material;

    void Start()
    {
        float[] _area = new float[2] { area.x, area.y };
        material.SetFloatArray("_Border", _area);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1.0f, 0.92f, 0.016f, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(area.x, 1, area.y));
    }
}
