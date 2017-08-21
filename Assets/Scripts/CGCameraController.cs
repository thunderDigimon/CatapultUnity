using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CGCameraController handles the camera to follow the ball
/// </summary>
public class CGCameraController : MonoBehaviour 
{
	[SerializeField]
	private Transform mPlayer;

	private float mSpeed = 2f;

	void OnEnable()
	{
		transform.LookAt (mPlayer);
	}


	void Update()
	{
		float interpolation = mSpeed * Time.deltaTime;

		Vector3 pos = transform.position ;

		pos.x = Mathf.Lerp (transform.position.x, mPlayer.position.x, interpolation);

		pos.y = Mathf.Lerp (transform.position.y, mPlayer.position.y+0.75f, interpolation);

		pos.z = Mathf.Lerp (transform.position.z, mPlayer.position.z-3, interpolation);

		transform.position =  pos;

	}


}
