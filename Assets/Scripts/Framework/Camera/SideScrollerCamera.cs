using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrollerCamera : BaseCamera {

    [SerializeField]
    private float _maxXDelta = 1f;

    [SerializeField]
    private float _maxYDelta = 1f;

    private Vector2 _maxCameraPos, _minCameraPos;

    private bool NeedMoveOnX()
    {
        return Mathf.Abs(transform.position.x - _player.position.x) > _maxXDelta;
    }

    private bool NeedMoveOnY()
    {
        return Mathf.Abs(transform.position.y - _player.position.y) > _maxYDelta;
    }

    protected override void FollowPlayer()
    {
        float cameraX, cameraY;
        float smoothing = _smoothingFactor * Time.deltaTime;

        if (NeedMoveOnX())
        {
            cameraX = Mathf.Lerp(transform.position.x, _player.position.x, smoothing);
        }
        else
        {
            cameraX = transform.position.x;
        }

        if (NeedMoveOnY())
        {
            cameraY = Mathf.Lerp(transform.position.y, _player.position.y, smoothing);
        }
        else
        {
            cameraY = transform.position.y;
        }

        cameraX = Mathf.Clamp(cameraX, _minCameraPos.x, _maxCameraPos.x);
        cameraY = Mathf.Clamp(cameraY, _minCameraPos.y, _maxCameraPos.y);

        transform.position = new Vector3(cameraX, cameraY, transform.position.z);
    }
}
