using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D oher)
    {
        Player player = oher.GetComponent<Player>();

        if(player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
