using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    [SerializeField] private GameObject template;
    [SerializeField] private GameObject[] spawns;

    private Transform[] _spawnsPoints = new Transform[4];
    private float _timer = 0;
    private int _count = 1;

    private void Start()
    {
        for (int count = 1; count <= spawns.Length; count++)
        {
            _spawnsPoints[count-1] = spawns[count-1].transform;
        }
    }

    private void Update()
    {
       CreateEnemie();
    }
    private void CreateEnemie()
    {
        if (_timer >= 2)
        {
             Instantiate(template, _spawnsPoints[_count-1].position, Quaternion.identity);
            _timer = 0;
            if (_count == 4)
            {
                _count = 1;
            }
            else
            {
                ++_count;
            }
        }
        else
        {
            _timer += Time.deltaTime;
        }
    }
}
