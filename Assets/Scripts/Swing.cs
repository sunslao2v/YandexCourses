using UnityEngine;

public class Swing : MonoBehaviour, IMover
{
    [SerializeField] private float _speed = 50000;
    [SerializeField] private float _angel;
    [SerializeField] private AnimationCurve _dynamic;
    [SerializeField] private float _distance;
    [SerializeField] private Transform _centre;

    public Vector3 Evaluate(float time)
    {
        float currentSpeed = _speed * _dynamic.Evaluate(_angel / -180);
        time *= currentSpeed;
        _angel = Mathf.PingPong(time, 180) * -1;

        Vector3 centre = new Vector3(_centre.position.x, _centre.position.y, 0);
        Vector3 offset = new Vector3(Mathf.Cos(_angel * Mathf.Deg2Rad), Mathf.Sin(_angel * Mathf.Deg2Rad), 0) * _distance;
        Vector3 target = centre + offset;

        return target;
    }
}
