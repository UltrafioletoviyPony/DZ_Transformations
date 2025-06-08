using UnityEngine;

public class RotatingByY : MonoBehaviour
{
    [SerializeField] private float _speed;

    private RotatingByY() =>
        _speed = 50;

    private void Update() =>
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
}