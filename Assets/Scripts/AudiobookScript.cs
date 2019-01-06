using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudiobookScript : MonoBehaviour {

	int musicTrack = 0;
	AudioSource audioSource;
	//public AudioClip[] clipNames;
	public List<AudioClip> CLIP_NAMES;
	public Text title;
	public Slider musicLength;
	public bool stopMusic = false;

	public GameObject GM;


	// Use this for initialization
	void Start () {

		audioSource = GetComponent<AudioSource>();
		GM = GameObject.FindGameObjectWithTag("GameManager");
		if(CLIP_NAMES[0] != null) {
			AddTitle();
		}
		StopAudio();
		//StartAudio();		
	}
	
	// Update is called once per frame
	void Update () {
		if(CLIP_NAMES[0] != null)
		{
			//title.text = audioSource.clip.name;
			if(!stopMusic)
			{
				musicLength.value += Time.deltaTime;
			}
			if(musicLength.value >= audioSource.clip.length)
			{
				musicTrack++;
				if(musicTrack >= CLIP_NAMES.Count)
				{
					musicTrack = 0;
				}
			}
		}
		else
		{
			title.text = "Nothing to play. Get some audio!";
		}
		
	}

	public void StartAudio(int changeMusic = 0)
	{
			musicTrack += changeMusic;
			if(musicTrack >= CLIP_NAMES.Count)
			{
				musicTrack = 0;
			}
			else if (musicTrack < 0)
			{
				musicTrack = CLIP_NAMES.Count - 1;
			}

			if(audioSource.isPlaying && changeMusic == 0)
			{
				return;
			}

			if(stopMusic)
			{
				stopMusic = false;
			}

			audioSource.clip = CLIP_NAMES[musicTrack];
			title.text = audioSource.clip.name;
			musicLength.maxValue = audioSource.clip.length;
			musicLength.value = 0;
			audioSource.Play();
	}

	public void StopAudio()
	{
		audioSource.Stop();
		stopMusic = true;
	}

	public void AddTitle() {
		audioSource.clip = CLIP_NAMES[0];
		title.text = audioSource.clip.name;
	}
}
