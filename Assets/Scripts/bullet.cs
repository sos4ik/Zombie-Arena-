using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private float _speed = 35f;
    public int Damage = 2;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0 , 0);

        StartCoroutine(bulletremove());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.Hurt(Damage);
        }

        Destroy(gameObject);
    }
    private IEnumerator bulletremove()
    {
        yield return new WaitForSeconds(3);

        Destroy(this.gameObject);
    }


}
