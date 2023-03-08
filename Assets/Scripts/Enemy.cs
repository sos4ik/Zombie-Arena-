using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    void Start()
    {
        _health = 5;
    }

    private void Update()
    {

        if(_health == 0)
        {
            Destroy(gameObject);
        }
    }

    public void Hurt(int Damage)
    {
        _health -= Damage;
    }

}
