using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMoving : MonoBehaviour
{
    private float _currentTime;
    private Vector3 _startPosition;
    private Vector3 _endPosition;

    private void Awake()
    {
        _startPosition = transform.position;
        _startPosition.x -= 2;
        _endPosition = transform.position;
        _endPosition.x += 2;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, 1);
        var newPosition = Vector3.Lerp(_startPosition, _endPosition, progress);
        transform.position = newPosition;
    }
}
