using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RopeAttachment : MonoBehaviour
{
    [SerializeField] private SpringJoint2D _player;

    private Rigidbody2D _ropePart;


    private void Start()
    {
        _ropePart = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_player.enabled == false)
        {
            _player.enabled = true;
            _player.connectedBody = _ropePart;
        }
    }
}
