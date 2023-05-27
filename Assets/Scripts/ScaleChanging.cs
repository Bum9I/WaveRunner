using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanging : MonoBehaviour
{
    private float _currentTime;
    private Vector3 _startScale;
    private Vector3 _endScale;

    private void Awake()
    {
        _startScale = transform.localScale;
        _endScale = transform.localScale;
        _endScale.x += 4;
        _endScale.y += 4;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, 1);
        var newScale = Vector3.Lerp(_startScale, _endScale, progress);
        transform.localScale = newScale;
    }
}
