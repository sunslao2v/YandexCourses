using UnityEngine;

public class RopeDetachment : MonoBehaviour
{
    private SpringJoint2D _playerHand;

    private void Start()
    {
        _playerHand = GetComponent<SpringJoint2D>();
    }

    private void Update()
    {
        if (_playerHand.enabled == true && Input.GetMouseButtonDown(0))
            _playerHand.enabled = false;
    }
}
