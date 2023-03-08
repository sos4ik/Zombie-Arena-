using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsInpit : MonoBehaviour
{

    private float offset;

    private void FixedUpdate()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
    }
}
