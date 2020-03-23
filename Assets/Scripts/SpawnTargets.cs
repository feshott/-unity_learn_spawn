using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    [SerializeField] private GameObject template;
    [SerializeField] private Transform[] spawnPoints;

    private float _timer = 0;
    private int _count = 0;

    private void Update()
    {
       CreateEnemie();
    }

    private void CreateEnemie()
    {
        if (_timer >= 2)
        {
             Instantiate(template, spawnPoints[_count].position, Quaternion.identity);
            _timer = 0;

            if (_count < spawnPoints.Length-1)
            {
                ++_count;
            }
            else
            {
                _count = 0;
            }
        }
        else
        {
            _timer += Time.deltaTime;
        }
    }
}
