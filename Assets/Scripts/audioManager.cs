using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class audioManager : MonoBehaviour
{
   AudioSource audioMusic;
    public AudioClip bandaSonora;
    public AudioClip fxDead;
    public AudioClip fxButton;
    public AudioClip fxCoin;
    public AudioClip fxFire;

    AudioSource _audioSource;

    public GameObject musicObj;

    public static audioManager Instance;

    void Awake(){
        if(Instance !=null && Instance !=this){
            Destroy(this.gameObject);
        }else {
            Instance=this;
            DontDestroyOnLoad(this.gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
     _audioSource= this.GetComponent<AudioSource>();
    

     audioMusic= musicObj.GetComponent<AudioSource>();
        audioMusic.clip= bandaSonora; 
     audioMusic.loop= true;  
     audioMusic.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

 public void SonarClipUnaVez(AudioClip ac){
    _audioSource.PlayOneShot(ac);
  }
}
