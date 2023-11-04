using UnityEngine;

public class TimeManager : MonoBehaviour {

	public float slowdownFactor = 0.0000001f;
	public float slowdownLength = 1f;

	void Update ()
	{
		Time.timeScale += (10f / slowdownLength) * Time.unscaledDeltaTime;
		Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
	}

	public void DoSlowmotion ()
	{
		Time.timeScale = slowdownFactor;
		Time.fixedDeltaTime = Time.timeScale * .02f;
	}

}