using UnityEngine;

public class MovingForward : MonoBehaviour
{
    private float _speed;

    private MovingForward() =>
        _speed = .02f;
    

    private void Update() =>
        transform.Translate(Vector3.forward * _speed, Space.Self);
}