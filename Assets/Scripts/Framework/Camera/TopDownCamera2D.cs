using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera2D : BaseCamera {

    protected override void FollowPlayer()
    {
        float lerpValue = _smoothingFactor * Time.deltaTime;

        float cameraDestinationX = Mathf.Lerp(transform.position.x, _player.position.x, lerpValue);
        float cameraDestinationY = Mathf.Lerp(transform.position.y, _player.position.y, lerpValue);

        transform.position = new Vector3(cameraDestinationX, cameraDestinationY);
    }
}
