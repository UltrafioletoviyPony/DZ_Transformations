using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Scaling() =>
        _speed = .1f;

    private void Update() =>
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
}