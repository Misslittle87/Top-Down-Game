using Assets._Project.Script.Characters;
using UnityEngine;

namespace Assets._Project.Script.Player
{
    [RequireComponent(typeof(BaseMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private BaseMovement movement;

        private void Awake()
        {
            movement = GetComponent<BaseMovement>();
        }

        private void Update()
        {
            Vector2 input = new Vector2(
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical")
            );

            movement.SetMoveDirection(input);
        }
    }
}
