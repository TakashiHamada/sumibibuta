using UnityEngine;
using System.Collections;

public class Boot : MonoBehaviour {
    
    private Memo memo;
    private GameObject audio_object;
    
	void Start () {
        var game_object = Resources.Load("TestAudioObject") as GameObject;
        audio_object = Instantiate(game_object) as GameObject;
        audio_object.SendMessage("ChangeSpeed", 2f);
    
        memo = new Memo();
	}
	
	void Update () {
        memo.Log(audio_object.transform.localPosition);

//		audio_object.GetComponent<AudioSource>().pitch -= 0.0001f;
	}
}
