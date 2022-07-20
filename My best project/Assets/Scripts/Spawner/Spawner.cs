using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;   


    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        int spawnPointNumber = Random.Range(0, _spawnPoints.Length);   
        Instantiate(_prefab, _spawnPoints[spawnPointNumber]);   
    }
}
