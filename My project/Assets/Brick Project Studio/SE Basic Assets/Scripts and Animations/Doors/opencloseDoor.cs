using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;

		private PlayerInput input;
        private void Awake()
        {
            input = GetComponent<PlayerInput>();
        }

        void Start()
		{
			open = false;
		}

        private void Update()
        {
			DoorOpenClose();
        }

        private void DoorOpenClose()
        {
			if (Player)
			{
				float dist = Vector3.Distance(Player.position, transform.position);
				if (dist < 15)
				{
					if (open == false)
					{
						if (input.interactKey)
						{
							StartCoroutine(opening());
						}
					}
					else
					{
						if (open == true)
						{
							if (input.interactKey)
							{
								StartCoroutine(closing());
							}
						}

					}

				}
			}
		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}