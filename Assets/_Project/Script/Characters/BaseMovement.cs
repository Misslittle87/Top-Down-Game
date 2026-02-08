using UnityEngine;

namespace Assets._Project.Script.Characters
{
    

    [RequireComponent(typeof(Rigidbody2D))]
    public class BaseMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        private Rigidbody2D rb;
        private Vector2 moveDirection;

        public Vector2 MoveDirection => moveDirection;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void SetMoveDirection(Vector2 direction)
        {
            moveDirection = direction.normalized;
        }

        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
        }
    }

}
