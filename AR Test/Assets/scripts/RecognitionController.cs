using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


//probably attach something similar to this to each image attached to the card being recognized


public class RecognitionController : MonoBehaviour,
ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;
	private Animator anim;
	public bool detected;

	void Start()
	{
		detected = false;
		anim = GetComponent<Animator> ();

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			//GameObject.Find ("merchTrans1").GetComponent<merchTrans1Anim> ().TriggerAnimation ();
			detected = true;

			Debug.Log ("detected = " + detected);



			// Play audio when target is found
			//audio.Play();
		}
		else
		{
			// Stop audio when target is lost
			//audio.Stop();

			detected = false;
			Debug.Log ("detected = " + detected);

		}
	}   
}