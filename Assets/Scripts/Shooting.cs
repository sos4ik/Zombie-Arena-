using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject _bulletPref;
    private GameObject _bullet;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            _bullet = Instantiate(_bulletPref) as GameObject;
            _bullet.transform.position = transform.TransformPoint(Vector2.right * 0.7f);
            _bullet.transform.rotation = transform.rotation;

        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.TransformDirection(Vector2.right) * 5f);
    }
}
