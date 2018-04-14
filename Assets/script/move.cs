using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	Rigidbody2D player;
	Animator player_anim;
  

	// Use this for initialization
	void Start () {
		player_anim = GetComponent<Animator> ();
    player = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

    player_anim.SetFloat ("stayControl", 0);
    
		if(Input.GetKey(KeyCode.UpArrow)) {
			player.velocity = new Vector2(0, 3);
      // transform.Translate(new Vector2(0, 0.1f));
			player_anim.SetFloat ("walkControlX", 0);
      player_anim.SetFloat ("walkControlY", 1);
      player_anim.SetFloat ("stayControl", 1);
		}
			
		if(Input.GetKey(KeyCode.DownArrow)){
			player.velocity = new Vector2(0, -3);
      // transform.Translate(new Vector2(0, -0.1f));
			player_anim.SetFloat ("walkControlX", 0);
      player_anim.SetFloat ("walkControlY", -1);
      player_anim.SetFloat ("stayControl", 1);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			player.velocity = new Vector2(-3, 0);
      // transform.Translate(new Vector2(-0.1f, 0));
      player_anim.SetFloat ("walkControlX", -1);
      player_anim.SetFloat ("walkControlY", 0);
      player_anim.SetFloat ("stayControl", 1);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			player.velocity = new Vector2(3, 0);
      // transform.Translate(new Vector2(0.1f, 0));
      player_anim.SetFloat ("walkControlX", 1);
      player_anim.SetFloat ("walkControlY", 0);
      player_anim.SetFloat ("stayControl", 1);
		}

    

    

    
	}


}
