using UnityEngine;

public class MoveToTargetPattern : IMover
{
    private Transform _target;
    private IMovable _movable;

    private bool _isMoving;

    public MoveToTargetPattern(Transform target, IMovable movable)
    {
        _target = target;
        _movable = movable;
    }

    public void StartMove() => _isMoving = true;

    public void StopMove() => _isMoving = false;

    public void Update()
    {
        if (_isMoving == false)
            return;

        Vector3 direction = _target.position - _movable.Transform.position; 
        _movable.Transform.Translate(direction.normalized * _movable.Speed * Time.deltaTime);
    }
}