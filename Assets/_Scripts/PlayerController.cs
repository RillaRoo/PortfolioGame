using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveSpeed;

	public CharacterController controller;

	public Transform orientation;

	float horizontalInput;
	float verticalInput;

	Vector3 moveDirection;


	private void Update()
	{
		MyInput();
		MovePlayer();
	}

	

	private void MyInput()
	{
		horizontalInput = Input.GetAxisRaw("Horizontal");
		verticalInput = Input.GetAxisRaw("Vertical");
	}

	private void MovePlayer()
	{
		moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
		controller.Move(moveDirection * moveSpeed * Time.deltaTime);
	}
}
