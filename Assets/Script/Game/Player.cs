using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SingletonMonoBehaviourFast<Player>
{
    [SerializeField]
    private float Speed = 0.0f;
    [SerializeField]
    private float RotSpeed = 0.0f;

    [SerializeField]
    private GameArea gameArea;

    private Vector2 area;

    private float angle;
    private Quaternion Angle;
    private Vector3 mousePos;

    void Start()
    {
        area = gameArea.Area;
    }
    
    void Update()
    {

        if(Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = Camera.main.transform.position.y;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            
            angle = Mathf.Atan2(mousePos.z - transform.root.position.z, mousePos.x - transform.root.position.x);
            Angle = Quaternion.Euler(new Vector3(0, (((Mathf.PI - angle) - Mathf.PI * 0.5f) / Mathf.PI) * 180.0f, 0));
            transform.root.rotation = Quaternion.Lerp(Angle, transform.root.rotation, RotSpeed);
            float rot = ((180.0f - transform.eulerAngles.y) / 180.0f) * Mathf.PI - (Mathf.PI * 0.5f);
            transform.position += new Vector3(Mathf.Cos(rot) * Speed, 0.0f, Mathf.Sin(rot) * Speed);
        }
        Vector2 size = area * 0.5f;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -size.x, size.x), 
                                         transform.position.y, 
                                         Mathf.Clamp(transform.position.z, -size.y, size.y));
    }

    static public GameObject GetPlayer()
    {
        return Instance.gameObject;
    }
}
