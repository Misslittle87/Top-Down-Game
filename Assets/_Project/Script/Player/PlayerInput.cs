using Assets._Project.Script.Characters;
using UnityEngine;

namespace Assets._Project.Script.Player
{
    [RequireComponent(typeof(Player))]
    public class PlayerInput : MonoBehaviour
    {
        private Player player;

        private void Awake()
        {
            player = GetComponent<Player>();
        }

        private void Update()
        {
            Vector2 input = player.Controls.GamePlay.Move.ReadValue<Vector2>();
            player.Movement.SetMoveDirection(input);
        }
    }
}
