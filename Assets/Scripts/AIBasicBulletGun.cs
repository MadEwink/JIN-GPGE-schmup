using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBasicBulletGun : BulletGun
{
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Fire();
    }
}
