using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : SingletonMonoBehaviour<GameArea>
{
    public Vector2 Area
    {
        get { return area; }
    }

    [SerializeField]
    private Vector2 area;

    [SerializeField]
    private Material material;

    [SerializeField]
    private GameObject[] leftRightLine = new GameObject[2];

    [SerializeField]
    private GameObject[] upDownLine = new GameObject[2];

    [SerializeField]
    private Vector2 lineSize;

    void OnValidate()
    {
        BorderChange();
    }

    void Start()
    {
        float[] _area = new float[2] { area.x, area.y };
        material.SetFloatArray("_Border", _area);
        BorderChange();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1.0f, 0.92f, 0.016f, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(area.x, 1, area.y));
    }

    void BorderChange()
    {
        Vector2 size = new Vector2(lineSize.x * 0.5f, lineSize.y * 0.5f);
        leftRightLine[0].transform.localScale = new Vector3(lineSize.x, lineSize.y, area.y);
        leftRightLine[0].transform.localPosition = new Vector3(-area.x * 0.5f - size.x, 0, 0);
        leftRightLine[1].transform.localScale = new Vector3(lineSize.x, lineSize.y, area.y);
        leftRightLine[1].transform.localPosition = new Vector3(area.x * 0.5f + size.x, 0, 0);
        upDownLine[0].transform.localScale = new Vector3(area.x, lineSize.y, lineSize.x);
        upDownLine[0].transform.localPosition = new Vector3(0, 0, area.y * 0.5f + size.y);
        upDownLine[1].transform.localScale = new Vector3(area.x, lineSize.y, lineSize.x);
        upDownLine[1].transform.localPosition = new Vector3(0, 0, -area.y * 0.5f - size.y);
    }
}
