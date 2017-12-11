using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chanController : MonoBehaviour {

    private Animator chanAni;
     
	void Start () {
        chanAni = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (VoiceTest.audioToString=="跳")
        {
            Debug.Log("VoiceTest.audioToString");
            chanAni.SetBool("boxing",false);
            chanAni.SetBool("sit",false);
            chanAni.SetBool("foot",false);
            chanAni.SetBool("jump",true);
            
        }
      
           
        if (VoiceTest.audioToString=="出拳")
        {
            chanAni.SetBool("jump", false);
            chanAni.SetBool("sit", false);
            chanAni.SetBool("foot", false);
            chanAni.SetBool("boxing", true);
        }
      
            if (VoiceTest.audioToString=="坐下")
        {
            chanAni.SetBool("boxing", false);
            chanAni.SetBool("jump", false);
            chanAni.SetBool("foot", false);
            chanAni.SetBool("sit", true);
        }
       
        if (VoiceTest.audioToString=="踢腿")
        {

            chanAni.SetBool("boxing", false);
            chanAni.SetBool("sit", false);
            chanAni.SetBool("jump", false);
            chanAni.SetBool("foot", true);
        }
      
        
    }
}
