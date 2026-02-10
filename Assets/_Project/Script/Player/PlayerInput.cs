using Assets._Project.Script.Characters;
using UnityEngine;

namespace Assets._Project.Script.Player
{
    [RequireComponent(typeof(BaseMovement))]
    [RequireComponent(typeof(Player))]
    public class PlayerInput : MonoBehaviour
    {
        private BaseMovement movement;
        private Player player;

        private void Awake()
        {
            movement = GetComponent<BaseMovement>();
            player = GetComponent<Player>();
        }

        private void Update()
        {
            Vector2 input = player.Controls.GamePlay.Move.ReadValue<Vector2>();
            movement.SetMoveDirection(input);
        }
    }
}
