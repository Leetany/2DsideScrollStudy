﻿using UnityEngine;

public class Slash : MonoBehaviour
{
    private GameObject p;
    public Vector3 direction = Vector3.right;
    Vector2 MousePos;
    Vector3 dir;

    float angle;
    Vector3 dirNo;



    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");
        Transform tr = p.GetComponent<Transform>();
        MousePos = Input.mousePosition;
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        Vector3 Pos = new Vector3(MousePos.x, MousePos.y, 0);
        dir = Pos - tr.position;

        //바라보는 각도 구하기
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    }

    
    void Update()
    {
        //회전 적용
        transform.rotation = Quaternion.Euler(0, 0, angle);

        transform.position = p.transform.position;
    }

    public void Des()
    {
        Destroy(gameObject);
    }
}
