using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private void Start()
    {
        StartCoroutine(Spawn());    
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds timer = new WaitForSeconds(_secondsBetweenSpawn);

        while (true)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_prefab, _spawnPoints[spawnPointNumber]);
            yield return timer; 
        }
    }
}
