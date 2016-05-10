using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
    
    private float speed;
    
    public void ChangeSpeed(float _speed) {
        speed = _speed;
    }
    
	void Update () {
        transform.localPosition = new Vector3(Mathf.Sin(Time.time) * speed, 0f, Mathf.Cos(Time.time) * speed);
	}
}
