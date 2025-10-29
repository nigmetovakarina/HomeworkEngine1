using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiObjectController : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    public float moveSpeed = 5f; 
    public uint objectCount = 3; 

    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -5f;
    public float maxY = 5f;


    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f) * moveSpeed * Time.deltaTime;

        if (objectCount >= 1) MoveAndClamp(object1, movement);
        if (objectCount >= 2) MoveAndClamp(object2, movement);
        if (objectCount >= 3) MoveAndClamp(object3, movement);
    }

    void MoveAndClamp(GameObject obj, Vector3 movement)
    {
        if (obj == null) return;

        obj.transform.Translate(movement);

        Vector3 pos = obj.transform.position;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        obj.transform.position = pos;
    }
}