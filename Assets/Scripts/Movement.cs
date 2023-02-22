using UnityEngine;

public class Movement : MonoBehaviour
{
    private IMover _mover;
    private float _time;

    private Rigidbody2D _rigidBody2D;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void LateUpdate()
    {
        _time += Time.deltaTime;
        _rigidBody2D.position = _mover.Evaluate(_time);
    }
}
