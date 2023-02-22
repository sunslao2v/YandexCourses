using UnityEngine;

public class Jumpment : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidBody2D;
    private Slide _slide;
    private bool _isJumping;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _slide = GetComponent<Slide>();
    }

    private void Update()
    {
        _rigidBody2D.AddForce(_slide.GroundNormal * _jumpForce, ForceMode2D.Impulse);
    }
}
