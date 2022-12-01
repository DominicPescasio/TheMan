using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/SpeedBuff")]
public class SpeedBuff : PowerUpEffect
{
    public float amount;
    public float duration;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlatformerMove>().moveSpeed += amount;
    }
}
