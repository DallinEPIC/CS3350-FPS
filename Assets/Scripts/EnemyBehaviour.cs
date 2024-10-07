using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _currentHealth;

    void Start()
    {
        _currentHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit()
    {
        _currentHealth -= 1;
        if(_currentHealth < 0)
        {
            transform.Rotate(-75f, 0, 0);
        }
    }
}
