using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : CharacterBehaviour
{
    public override void Die()
    {
        transform.Rotate(-75f, 0, 0);
    }

    void Update()
    {
        transform.LookAt(PlayerController.instance.transform);
    }
}
