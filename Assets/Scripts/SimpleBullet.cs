using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    public override void UpdatePosition()
    {
        Position = transform.position;
        Position += Speed * Time.deltaTime;
        transform.position = Position;
    }
}
