using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    [SerializeField] private GameObject template;
    [SerializeField] private GameObject[] spawnsPoints;

    private Transform[] _spawnsPointsPosition = new Transform[4];
    private float _timer = 0;
    private int _count = 0;

    private void Start()
    {
        for (int count = 0; count < spawnsPoints.Length; count++)
        {
            _spawnsPointsPosition[count] = spawnsPoints[count].transform;
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
             Instantiate(template, _spawnsPointsPosition[_count].position, Quaternion.identity);
            _timer = 0;

            if (_count < _spawnsPointsPosition.Length-1)
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
