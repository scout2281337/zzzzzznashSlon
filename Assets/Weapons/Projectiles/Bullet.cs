using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Bullet : Projectile
{
    public void SetBullet(float speed, Vector2 diraction)
    {
        SetProjectile(speed, diraction);
    }
}
