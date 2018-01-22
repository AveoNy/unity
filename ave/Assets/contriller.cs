using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class contriller : MonoBehaviour {
    private Animation anim;
    private Rigidbody av;
	[SerializeField]
	private float speed = 4f;
	// Use this for initialization
	void Start () {
	    anim = GetComponent <Animation> ();
		av = GetComponent <Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");
		
		
		Vector3 movement = new Vector3 (x, 0, y);
		av.velocity = movement * speed;
		
		if (x != 0 && y !=0)
		    transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2 (x,y) * Mathf.Rad2Deg, transform.eulerAngles.z);
		if (x !=0 || y!=0)
		    anim.Play ("Running");
		else 
		    anim.Play ("Idle");
	}
}
