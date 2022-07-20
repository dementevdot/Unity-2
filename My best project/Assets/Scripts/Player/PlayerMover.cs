using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float _speed;

    private void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical");

        if (verticalAxis != 0)
            transform.Translate(new Vector2(0, verticalAxis * _speed * Time.deltaTime));  
    }
}
