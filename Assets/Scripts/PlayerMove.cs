using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _force = 50000;

    private Rigidbody2D _rigidBody2D;

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _rigidBody2D.AddForce(transform.right * _force);
    }
}
