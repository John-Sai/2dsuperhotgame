using UnityEngine;

public class TimeManager : MonoBehaviour {

	public float slowdownFactor = 0;
	public float slowdownLength = 1f;

	void Update ()
	{	
	}

	public void DoSlowmotion ()
	{
		Time.timeScale = slowdownFactor;
		Time.fixedDeltaTime = Time.timeScale * .02f;
	}

	public void UnDoSlowmotion ()
	{
		Time.timeScale = 1;
	}

}