using Assets._Project.Script.Characters;
using UnityEngine;

namespace Assets._Project.Script.Player
{
    [RequireComponent(typeof(BaseMovement))]
    public class Player : MonoBehaviour
    {
        public BaseMovement Movement { get; private set; }
        public PlayerInput PlayerInput { get; private set; }
        public PlayerShooting PlayerShooting { get; private set; }
        public PlayerControls Controls { get; private set; }
        //healt
        //interaction
        //inventory


        private void Awake()
        {
            Movement = GetComponent<BaseMovement>();
            PlayerInput = GetComponent<PlayerInput>();
            PlayerShooting = GetComponent<PlayerShooting>();
            Controls = new PlayerControls();
        }

        private void OnEnable() => Controls.Enable();

        private void OnDisable() => Controls.Disable();

    }
}
