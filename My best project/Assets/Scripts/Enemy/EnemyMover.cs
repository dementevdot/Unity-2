using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] float _speed;

    private void Update()
    {
        transform.Translate(new Vector2(_speed * Time.deltaTime * -1, 0));
    }
}
