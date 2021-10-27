using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summoncar : MonoBehaviour
{
    public GameObject projectile;
    public float attackTime = 0f;
    public Transform[] spawnPoints;
    public float delay;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay = Random.Range(.5f, 1f);
        if (attackTime <= Time.time)
        {
            Attack();
            attackTime = Time.time + delay;
        }
    }
    private void Attack()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnpoint = spawnPoints[randomIndex];
        Instantiate(projectile,spawnpoint.position,spawnpoint.rotation);
    }
}
