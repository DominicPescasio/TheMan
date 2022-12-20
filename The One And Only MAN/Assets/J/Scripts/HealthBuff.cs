using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/HealthBuff")]
public class HealthBuff : PowerUpEffect
{
    public int amount = 1;

    public override void Apply(GameObject target)
    {
        target.GetComponent<playerHealthUI>().health += amount;
    }
}
