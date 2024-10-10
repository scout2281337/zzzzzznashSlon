using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rocket : Projectile
{
    public void SetRocket(float speed, Vector2 diraction, float radius, float force)
    {
        SetExplosiveProjectile(speed, diraction, radius, force);
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        Explosion();
    }
}
