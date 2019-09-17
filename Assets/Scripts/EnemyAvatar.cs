using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAvatar : BaseAvatar
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

	public override void Die()
	{ 
		Destroy(gameObject);
	}
}
