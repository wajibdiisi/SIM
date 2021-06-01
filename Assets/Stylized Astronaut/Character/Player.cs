using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;

		public float speed = 15.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;

		void Start () {
			controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
		}

		void Update (){
			float horizontal = Input.GetAxisRaw("Horizontal");
			Vector3 direction = new Vector3(horizontal,0f,1f).normalized;
			if( direction.magnitude >= 0.1f){
			float turn = Input.GetAxis("Horizontal");
			anim.SetInteger ("AnimationPar", 1);
			if(controller.enabled == true){
			controller.Move(direction * speed  * Time.deltaTime);
			}
			moveDirection.y -= gravity * Time.deltaTime;
			}else {
				anim.SetInteger ("AnimationPar", 0);
			}
		}
}
