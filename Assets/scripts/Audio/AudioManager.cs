using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManager : MonoBehaviour
{
    [Header("audioManage")]
    public static AudioManager instance;

    [Header("Volume")]
    public VolumeSaveControler volumeSave;
    public float masterVolume = 0.5f;
    private Bus masterbus;

    private void Awake(){
        instance = this;
        masterVolume = volumeSave.Volume;

        masterbus = RuntimeManager.GetBus("bus:/");
    }
    private void Update(){
        masterbus.setVolume(masterVolume);
    }

    public void PlayEvent(EventReference sound,Vector3 pos)
    {
        RuntimeManager.PlayOneShot(sound,pos);
    }


    public void SetVolume(float nVolume)
    {
        masterVolume = nVolume;
        volumeSave.Volume = nVolume;
    }
    public float GetVolume()
    {
       return masterVolume;
    }
}
