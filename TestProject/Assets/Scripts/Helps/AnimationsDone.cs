using UnityEngine;
using System.Collections;

public class AnimationsDone : MonoBehaviour {

    // Use this for initializatiopublic 
    public Animator ani_ButtonStart;
    public Animator ani_ButtonSetting;
    public bool Play;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Play)
        {
            ani_ButtonStart.enabled = true;
            ani_ButtonSetting.enabled = true;

        }
	
	}
}
