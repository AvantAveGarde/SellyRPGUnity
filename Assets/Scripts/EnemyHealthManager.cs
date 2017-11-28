using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int enemyMaxHP;

    public int enemyHP;
    void Start()
    {
        enemyHP = enemyMaxHP;
    }

    void Update()
    {
        if (enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        enemyHP -= damage;
    }
    public void SetMaxHealth()
    {
        enemyHP = enemyMaxHP;
    }
}
