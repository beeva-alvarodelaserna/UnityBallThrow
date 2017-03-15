using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class CollisionTest : MonoBehaviour {

	public AudioClip alert;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		// audio.PlayOneShot(alert, 0.7F);
		audio.Play();
	    print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
	    // print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
	    // print("Their relative velocity is " + collisionInfo.relativeVelocity);
	}

	void OnCollisionStay(Collision collisionInfo)
	{
	    print(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");
	}

	void OnCollisionExit(Collision collisionInfo)
	{
	    print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
	}

	void OnTriggerEnter(Collider other)
	{
	    print("Collision detected with trigger object " + other.name);
	}

	void OnTriggerStay(Collider other)
	{
	    print("Still colliding with trigger object " + other.name);
	}

	void OnTriggerExit(Collider other)
	{
	    print(gameObject.name + " and trigger object " + other.name + " are no longer colliding");
	}
}
