using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemyBasicEngine : MonoBehaviour
{
    private Engines engines;
    
    // Start is called before the first frame update
    void Start()
    {
        engines = GetComponent<Engines>();
        engines.Speed = new Vector2(-1, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
