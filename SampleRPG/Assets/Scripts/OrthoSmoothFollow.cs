using UnityEngine;
using System.Collections;

public class OrthoSmoothFollow : MonoBehaviour {

	private Camera cameraFreeWalk;
	public float zoomSpeed = 20f;
	public float minZoomFOV = 10f;

	public Transform target;
	public float smoothTime = 0.3f;

	private Vector3 velocity = Vector3.zero;

	void Update () {
		Vector3 goalPos = target.position;
		goalPos.y = transform.position.y;
		transform.position = Vector3.SmoothDamp (transform.position, goalPos, ref velocity, smoothTime);
	}

	public void ZoomIn()
	{
		cameraFreeWalk.fieldOfView -= zoomSpeed/8;
		if (cameraFreeWalk.fieldOfView < minZoomFOV)
		{
			cameraFreeWalk.fieldOfView = minZoomFOV;
		}
	}
}