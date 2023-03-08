using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player singleton { get; private set; }

    [SerializeField] private HealBar hp;
    [SerializeField] private float _speed = 4.5f;
    [SerializeField] private Rigidbody2D rb2;

    private int maxhealth = 10;
    public int currenthealth;

    Vector2 move;

    private void Awake()
    {
        singleton = this;
    }

    private void Start()
    {
        currenthealth = maxhealth;
        hp.SetMaxHealth(maxhealth);
    }


    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }


    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        hp.SetHeal(currenthealth);
    }

    private void FixedUpdate()
    {
        rb2.MovePosition(rb2.position + move * _speed * Time.fixedDeltaTime);
    }
}
