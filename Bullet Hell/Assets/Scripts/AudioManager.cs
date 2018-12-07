using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    private AudioSource audioSource;

    public AudioClip fireSound1;
    public AudioClip destroySound1;

    private Dictionary<int, AudioClip> IDToAudio;
    private void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

        audioSource = this.GetComponent<AudioSource>();
        IDToAudio = new Dictionary<int, AudioClip>() {
        {

            0, fireSound1

        },
        {

            1, destroySound1

        }
        };
    }

    public void Play(int soundID)
    {
        

        audioSource.PlayOneShot(IDToAudio[soundID]);
    }
    // Um einen Sound abzuspielen: 1: fügt man den Prefabs jeweils eine AudioSource hinzufügen wo der entsprechende Sound reinkommt
    //                             2: gibt man der MainKamera den AudioManager
    //                             3: Fügt man die sounds die man haben möchte in die richtigen Slots beim AudioManager ein
    //                             4: einen weiteren BlockID eintrag, sowie hier IDToAudio eintrag mit der jeweiligen ID beim enum von BlockID
    //  
    //                             5: wie man den audioclip dann abspielt -> AudioManager.instance.Play((int)GameObject.GetComponent<AudioID>().myID); 
}

