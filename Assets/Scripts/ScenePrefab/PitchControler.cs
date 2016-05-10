using UnityEngine;
using System.Collections;

public class PitchControler : MonoBehaviour {
	void Update () {
		var pitch = GetComponent<AudioSource> ().pitch;
		pitch -= 0.1f;
		if (pitch < 0f)
			pitch = 1f;
		GetComponent<AudioSource> ().pitch = pitch;
	}
}
