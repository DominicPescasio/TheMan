using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/SpeedBuff")]
public class SpeedBuff : PowerUpEffect
{
    public float amount = 0;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovements>().moveSpeed += amount;
    }
}
